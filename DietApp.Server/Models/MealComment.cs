using System.ComponentModel.DataAnnotations;

namespace DietApp.Server.models
{
	public class MealComment
	{
		[Key] public Guid Id { get; set; }
		[Required] public required string Content { get; set; }
		[Required] public required DateTime CreatedAd { get; set; }
		[Required] public Guid MealId { get; set; }
		public Meal? Meal { get; set; }
	}
}
