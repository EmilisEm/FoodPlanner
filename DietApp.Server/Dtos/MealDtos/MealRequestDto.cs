using System.ComponentModel.DataAnnotations;
using DietApp.Server.Dtos.MealCommentDtos;

namespace DietApp.Server.Dtos.MealDtos
{
	public class MealRequestDto
	{
		[Required] public required string Name { get; set; }
		[Required] public required string Instructions { get; set; }
		[Required] public required List<MealCommentRequestDto> Comments { get; set; }
	}
}
