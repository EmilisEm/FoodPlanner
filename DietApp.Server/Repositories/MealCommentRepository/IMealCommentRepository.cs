using DietApp.Server.models;

namespace DietApp.Server.Repositories.MealCommentRepository

{
	public interface IMealCommentRepository
	{
		public Task<MealComment?> GetMealCommentByIdAsync(Guid id);
		public Task<IEnumerable<MealComment>> GetMealCommentsByMealIdAsync(Guid id);
		public Task<MealComment> CrateMealCommentAsync(MealComment mealComment);
		public Task<int> UpdateMealCommentAsync(Guid id, MealComment mealComment);
		public Task<int> DeleteMealCommentAsync(Guid id);
	}
}
