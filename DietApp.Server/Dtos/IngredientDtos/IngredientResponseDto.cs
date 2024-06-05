using System.ComponentModel.DataAnnotations;
using DietApp.Server.Dtos.UnitDtos;

namespace DietApp.Server.Dtos.IngredientDtos
{
	public class IngredientResponseDto
	{
		public required Guid Id { get; set; }
		[Required]
		public required string Name { get; set; }
		[Required]
		public required List<UnitResponseDto> Units { get; set; }
	}
}
