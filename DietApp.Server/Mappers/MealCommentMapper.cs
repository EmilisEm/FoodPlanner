using DietApp.Server.Dtos.MealCommentDtos;
using DietApp.Server.models;

namespace DietApp.Server.Mappers
{
	public static class MealCommentMapper
	{
		public static MealCommentResponseDto ToDto(MealComment comment)
		{
			return new MealCommentResponseDto()
			{
				Id = comment.Id,
				Content = comment.Content,
				MealId = comment.MealId,
				CreatedAt = comment.CreatedAt,
			};
		}

		public static MealComment FromDto(MealCommentRequestDto comment)
		{
			return new MealComment()
			{
				Id = Guid.NewGuid(),
				Content = comment.Content,
				MealId = comment.MealId,
				CreatedAt = comment.CreatedAt,
			};
		}

		public static MealComment FromDto(Guid id, MealCommentRequestDto comment)
		{
			return new MealComment()
			{
				Id = id,
				Content = comment.Content,
				MealId = comment.MealId,
				CreatedAt = comment.CreatedAt,
			};
		}
	}
}
