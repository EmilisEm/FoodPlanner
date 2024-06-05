using DietApp.Server.Data;
using DietApp.Server.models;
using Microsoft.EntityFrameworkCore;

namespace DietApp.Server.Repositories.MealItemRepository
{
	public class MealItemRepository : IMealItemRepository
	{
		private readonly DietAppDbContex _context;

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
				// TODO: Exceptions
				throw new Exception("MealItem not found");
			}

			return await _context.SaveChangesAsync();
		}

		public async Task<MealItem?> GetMealItemByIdAsync(Guid id)
		{
			return await _context.MealsItem.FirstOrDefaultAsync(item => item.Id == id);
		}

		public async Task<List<MealItem>> GetMealItemsByMealIdAsync(Guid id)
		{
			return await _context.MealsItem.Where(item => item.MealId == id).ToListAsync();
		}

		public async Task<int> UpdateMealItemAsync(Guid id, MealItem mealItem)
		{
			MealItem? item = await _context.MealsItem.FirstOrDefaultAsync(item => item.Id == id);

			if (item == null)
			{
				// TODO: Exceptions
				throw new Exception("Meal item not found");
			}

			return await _context.SaveChangesAsync();
		}
	}
}
