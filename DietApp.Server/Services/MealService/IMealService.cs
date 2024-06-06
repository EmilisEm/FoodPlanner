using DietApp.Server.Dtos.MealDtos;

namespace DietApp.Server.Services.MealService
{
	public interface IMealService
	{
		public Task<MealResponseDto> GetMealAsync(Guid id);
		public Task<IEnumerable<MealResponseDto>> GetMealsAsync();
		public Task<MealResponseDto> CreateMealAsync(MealRequestDto mealRequestDto);
		public Task DeleteMealAsync(Guid id);
		public Task UpdateMealAsync(Guid id, MealRequestDto mealRequestDto);
	}
}
