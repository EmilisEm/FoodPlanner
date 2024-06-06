using System.ComponentModel.DataAnnotations;
using DietApp.Server.Dtos.UnitDtos;

namespace DietApp.Server.Dtos.IngredientDtos
{
	public class IngredientRequestDto
	{
		[Required]
		public required string Name { get; set; } = null!;
		[Required]
		public required IEnumerable<UnitRequestDto> Units { get; set; } = null!;
	}
}
