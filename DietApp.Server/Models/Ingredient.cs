using System.ComponentModel.DataAnnotations;

namespace DietApp.Server.models
{
	public class Ingredient
	{
		[Key] public Guid Id { get; set; }
		[Required] public required string Name { get; set; }
		[Required] public required IEnumerable<Unit> Units { get; set; } = new List<Unit>();
	}
}
