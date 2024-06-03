using DietApp.Server.Dtos.MealDtos;

namespace DietApp.Server.Services.MealService
{
	public class MealService : IMealService
	{
		public Task<MealResponseDto> CreateMealAsync(MealRequestDto mealRequestDto)
		{
			throw new NotImplementedException();
		}

		public Task DeleteMealAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<MealResponseDto> GetMealAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<List<MealResponseDto>> GetMealsAsync()
		{
			throw new NotImplementedException();
		}

		public Task UpdateMealAsync(Guid id, MealRequestDto mealRequestDto)
		{
			throw new NotImplementedException();
		}
	}
}
