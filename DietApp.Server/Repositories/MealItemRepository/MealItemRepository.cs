using DietApp.Server.Data;
using DietApp.Server.Exceptions;
using DietApp.Server.models;
using Microsoft.EntityFrameworkCore;

namespace DietApp.Server.Repositories.MealItemRepository
{
	public class MealItemRepository : IMealItemRepository
	{
		private readonly DietAppDbContex _context;
		private readonly string MEAL_ITEM_NOT_FOUND = "Meal item not found";

		public MealItemRepository(DietAppDbContex context)
		{
			_context = context;
		}

		public async Task<MealItem> CrateMealItemAsync(MealItem mealItem)
		{
			await _context.AddAsync(mealItem);
			await _context.SaveChangesAsync();

			return mealItem;
		}

		public async Task<int> DeleteMealItemAsync(Guid id)
		{
			MealItem? item = await _context.MealsItem.FirstOrDefaultAsync(item => item.Id == id);

			if (item == null)
			{
				throw new EntityNotFoundException(MEAL_ITEM_NOT_FOUND);
			}

			return await _context.SaveChangesAsync();
		}

		public async Task<MealItem?> GetMealItemByIdAsync(Guid id)
		{
			return await _context.MealsItem.FirstOrDefaultAsync(item => item.Id == id);
		}

		public async Task<IEnumerable<MealItem>> GetMealItemsByMealIdAsync(Guid id)
		{
			return await _context.MealsItem.Where(item => item.MealId == id).ToListAsync();
		}

		public async Task<int> UpdateMealItemAsync(Guid id, MealItem mealItem)
		{
			MealItem? item = await _context.MealsItem.FirstOrDefaultAsync(item => item.Id == id);

			if (item == null)
			{
				throw new EntityNotFoundException(MEAL_ITEM_NOT_FOUND);
			}

			return await _context.SaveChangesAsync();
		}
	}
}
