using System.Reflection.Metadata.Ecma335;
using DietApp.Server.Dtos.MealDtos;
using DietApp.Server.models;

namespace DietApp.Server.Mappers
{
	public static class MealMapper
	{
		public static Meal FromDto(MealRequestDto mealRequest)
		{
			return new Meal()
			{
				Id = Guid.NewGuid(),
				Name = mealRequest.Name,
				CreatedAt = DateTime.UtcNow,
				Instructions = mealRequest.Instructions,
				Comments = mealRequest.Comments.Select(MealCommentMapper.FromDto).ToList(),
			};
		}

		public static MealResponseDto ToDto(Meal meal)
		{
			return new MealResponseDto()
			{
				Id = meal.Id,
				Name = meal.Name,
				CreatedAt = meal.CreatedAt,
				Instructions = meal.Instructions,
				Comments = meal.Comments.Select(MealCommentMapper.ToDto).ToList(),
			};
		}

		public static Meal FromDto(MealRequestDto mealRequest, Guid id)
		{
			return new Meal()
			{
				Id = id,
				Name = mealRequest.Name,
				CreatedAt = DateTime.UtcNow,
				Instructions = mealRequest.Instructions,
				Comments = mealRequest.Comments.Select(MealCommentMapper.FromDto).ToList(),
			};
		}
	}
}
