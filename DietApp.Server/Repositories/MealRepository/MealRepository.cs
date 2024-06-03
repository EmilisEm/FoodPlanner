using DietApp.Server.Data;
using DietApp.Server.models;

namespace DietApp.Server.Repositories.MealRepository
{
	public class MealRepository : IMealRepository
	{
		private readonly DietAppDbContex _context;
		public MealRepository(DietAppDbContex context)
		{
			_context = context;
		}

		public Task<Meal> CrateMealAsync(Meal meal)
		{
			throw new NotImplementedException();
		}

		public Task<int> DeleteMealAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<Meal> GetMealByIdAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<List<Meal>> GetMealsAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<int> UpdateMealAsync(Guid id, Meal meal)
		{
			throw new NotImplementedException();
		}
	}
}
