using System.ComponentModel.DataAnnotations;

namespace DietApp.Server.Dtos.MealCommentDtos
{
	public class MealCommentResponseDto
	{
		[Required] public required Guid Id { get; set; }
		[Required] public required string Content { get; set; }
		[Required] public required DateTime CreatedAt { get; set; }
		[Required] public required Guid MealId { get; set; }
	}
}
