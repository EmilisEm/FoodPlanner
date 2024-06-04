using DietApp.Server.models;

namespace DietApp.Server.Repositories.MealCommentRepository

{
	public interface IMealCommentRepository
	{
		public Task<MealComment?> GetMealCommentByIdAsync(Guid id);
		public Task<List<MealComment>> GetMealCommentsByMealIdAsync(Guid id);
		public Task<MealComment> CrateMealCommentAsync(MealComment mealItem);
		public Task<int> UpdateMealCommentAsync(Guid id, MealComment mealItem);
		public Task<int> DeleteMealCommentAsync(Guid id);
	}
}
