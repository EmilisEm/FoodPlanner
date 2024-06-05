using System.ComponentModel.DataAnnotations;

namespace DietApp.Server.models
{
	public class Unit
	{
		[Key] public Guid Id { get; set; }
		[Required] public required string Name { get; set; }
		public IEnumerable<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
	}
}
