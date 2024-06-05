using DietApp.Server.models;

namespace DietApp.Server.Repositories.MealCommentRepository
{
	public class MealCommentRepository : IMealCommentRepository
	{
		public Task<MealComment> CrateMealCommentAsync(MealComment mealItem)
		{
			throw new NotImplementedException();
		}

		public Task<int> DeleteMealCommentAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<MealComment?> GetMealCommentByIdAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<List<MealComment>> GetMealCommentsByMealIdAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<int> UpdateMealCommentAsync(Guid id, MealComment mealItem)
		{
			throw new NotImplementedException();
		}
	}
}
