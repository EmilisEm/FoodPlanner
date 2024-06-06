using System.ComponentModel.DataAnnotations;

namespace DietApp.Server.models
{
	public class Meal
	{
		[Key] public Guid Id { get; set; }
		[Required] public required string Name { get; set; }
		[Required] public required string Instructions { get; set; }
		[Required] public required DateTime CreatedAt { get; set; }
		[Required] public required IEnumerable<MealComment> Comments { get; set; } = new List<MealComment>();
	}
}
