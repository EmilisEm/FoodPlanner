using System.ComponentModel.DataAnnotations;

namespace DietApp.Server.Dtos.MealCommentDtos
{
	public class MealCommentRequestDto
	{
		[Required] public required string Content { get; set; }
		[Required] public required DateTime CreatedAt { get; set; }
		[Required] public required Guid MealId { get; set; }
	}
}
