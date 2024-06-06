using System.ComponentModel.DataAnnotations;
using DietApp.Server.Dtos.MealCommentDtos;

namespace DietApp.Server.Dtos.MealDtos
{
	public class MealResponseDto
	{
		[Required] public Guid Id { get; set; }
		[Required] public required string Name { get; set; }
		[Required] public required string Instructions { get; set; }
		[Required] public required DateTime CreatedAt { get; set; }
		[Required] public required IEnumerable<MealCommentResponseDto> Comments { get; set; }
	}
}
