using DietApp.Server.Dtos.MealCommentDtos;

namespace DietApp.Server.Services.MealCommentService
{
	public interface IMealCommentService
	{
		public Task<MealCommentResponseDto> GetMealCommentAsync(Guid id);
		public Task<List<MealCommentResponseDto>> GetMealCommentsByMealIdAsync(Guid id);
		public Task<MealCommentResponseDto> CreateMealCommentAsync(MealCommentRequestDto mealCommentRequestDto);
		public Task DeleteMealCommentAsync(Guid id);
		public Task UpdateMealCommentAsync(Guid id, MealCommentRequestDto mealCommentRequestDto);
	}
}
