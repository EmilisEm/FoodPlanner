using DietApp.Server.models;

namespace DietApp.Server.Repositories.MealItemRepository
{
	public interface IMealItemRepository
	{
		public Task<MealItem?> GetMealItemByIdAsync(Guid id);
		public Task<IEnumerable<MealItem>> GetMealItemsByMealIdAsync(Guid id);
		public Task<MealItem> CrateMealItemAsync(MealItem mealItem);
		public Task<int> UpdateMealItemAsync(Guid id, MealItem mealItem);
		public Task<int> DeleteMealItemAsync(Guid id);
	}
}
