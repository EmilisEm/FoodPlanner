using DietApp.Server.Data;
using DietApp.Server.Exceptions;
using DietApp.Server.models;
using Microsoft.EntityFrameworkCore;

namespace DietApp.Server.Repositories.MealRepository
{
	public class MealRepository : IMealRepository
	{
		private readonly DietAppDbContex _context;
		private readonly string MEAL_NOT_FOUND = "Meal not found";
		public MealRepository(DietAppDbContex context)
		{
			_context = context;
		}

		public async Task<Meal> CrateMealAsync(Meal meal)
		{
			await _context.AddAsync(meal);
			await _context.SaveChangesAsync();

			return meal;
		}

		public async Task<int> DeleteMealAsync(Guid id)
		{
			Meal? meal = await _context.Meals.FirstOrDefaultAsync(meal => meal.Id == id);

			if (meal == null)
			{
				throw new EntityNotFoundException(MEAL_NOT_FOUND);
			}

			_context.Meals.Remove(meal);
			return await _context.SaveChangesAsync();
		}

		public async Task<Meal?> GetMealByIdAsync(Guid id)
		{
			return await _context.Meals.FirstOrDefaultAsync(meal => meal.Id == id);
		}

		public async Task<IEnumerable<Meal>> GetMealsAsync()
		{
			return await _context.Meals.ToListAsync();
		}

		public async Task<int> UpdateMealAsync(Guid id, Meal meal)
		{
			Meal? original = await _context.Meals.FirstOrDefaultAsync(meal => meal.Id == id);

			if (original == null)
			{
				throw new EntityNotFoundException(MEAL_NOT_FOUND);
			}

			_context.Entry(original).CurrentValues.SetValues(meal);
			return await _context.SaveChangesAsync();
		}
	}
}
