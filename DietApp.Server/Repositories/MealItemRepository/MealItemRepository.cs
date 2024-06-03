using DietApp.Server.models;

namespace DietApp.Server.Repositories.MealItemRepository
{
	public class MealItemRepository : IMealItemRepository
	{
		public Task<MealItem> CrateMealItemAsync(MealItem mealItem)
		{
			throw new NotImplementedException();
		}

		public Task<int> DeleteMealItemAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<MealItem> GetMealItemByIdAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<List<MealItem>> GetMealItemsByMealIdAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<int> UpdateMealItemAsync(Guid id, MealItem mealItem)
		{
			throw new NotImplementedException();
		}
	}
}
