using DietApp.Server.Data;
using DietApp.Server.Exceptions;
using DietApp.Server.models;
using Microsoft.EntityFrameworkCore;

namespace DietApp.Server.Repositories.IngredientRepository
{
	public class IngredientRepository : IIngredientRepository
	{
		private readonly DietAppDbContex _context;
		private readonly string INGREDIENT_NOT_FOUND = "Ingredient not found";

		public IngredientRepository (DietAppDbContex context)
		{
			_context = context;
		}

		public async Task<Ingredient> CrateIngredientAsync(Ingredient ingredient)
		{
			await _context.AddAsync(ingredient);
			await _context.SaveChangesAsync();

			return ingredient;
		}

		public async Task<int> DeleteIngredientAsync(Guid id)
		{
			Ingredient? ingredient = await _context.Ingredients.FirstOrDefaultAsync (ingredient => ingredient.Id == id);

			if (ingredient == null)
			{
				throw new EntityNotFoundException(INGREDIENT_NOT_FOUND);
			}

			_context.Remove(ingredient);
			return await _context.SaveChangesAsync();
		}

		public async Task<Ingredient?> GetIngredientByIdAsync(Guid id)
		{
			return await _context.Ingredients.Include(ingredient => ingredient.Units).FirstOrDefaultAsync(ingredient => ingredient.Id == id);
		}

		public async Task<IEnumerable<Ingredient>> GetIngredientsAsync()
		{
			return await _context.Ingredients.Include(ingredient => ingredient.Units).ToListAsync();
		}

		public async Task<int> UpdateIngredientAsync(Guid id, Ingredient ingredient)
		{
			Ingredient? original = await _context.Ingredients.FirstOrDefaultAsync(ingr => ingr.Id == id);

			if (original == null)
			{
				throw new EntityNotFoundException(INGREDIENT_NOT_FOUND);
			}

			_context.Entry(original).CurrentValues.SetValues(ingredient);
			return await _context.SaveChangesAsync();
		}
	}
}
