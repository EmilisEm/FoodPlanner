using DietApp.Server.Dtos.MealCommentDtos;

namespace DietApp.Server.Services.MealCommentService
{
	public class MealCommentService : IMealCommentService
	{
		public Task<MealCommentResponseDto> CreateMealCommentAsync(MealCommentRequestDto mealCommentRequestDto)
		{
			throw new NotImplementedException();
		}

		public Task DeleteMealCommentAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<MealCommentResponseDto> GetMealCommentAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<List<MealCommentResponseDto>> GetMealCommentsAsync()
		{
			throw new NotImplementedException();
		}

		public Task UpdateMealCommentAsync(Guid id, MealCommentRequestDto mealCommentRequestDto)
		{
			throw new NotImplementedException();
		}
	}
}
