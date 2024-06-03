using System.ComponentModel.DataAnnotations;

namespace DietApp.Server.models
{
	public class MealItem
	{
		[Key] public Guid Id { get; set; }
		[Required] public required int Quantity { get; set; }
		[Required] public Guid MealId { get; set; }
		[Required] public Guid UnitId { get; set; }
		[Required] public Guid IngredientId { get; set; }
		public Meal? Meal { get; set; }
		public Unit? Unit { get; set; }
		public Ingredient? Ingredient { get; set; }
	}
}
