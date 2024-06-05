using System.ComponentModel.DataAnnotations;

namespace DietApp.Server.Dtos.UnitDtos
{
	public class UnitRequestDto
	{
		[Required]
		public Guid Id { get; set; }
		[Required]
		public string Name { get; set; } = null!;
	}
}
