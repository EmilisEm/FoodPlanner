using System.ComponentModel.DataAnnotations;
using DietApp.Server.models;

namespace DietApp.Server.Models
{
	public class IngredientUnit
	{
		[Key] public Guid Id { get; set; }
		[Required] public Guid IngredientId { get; set; }
		[Required] public Guid UnitId { get; set; }
		public Ingredient? Ingredient { get; set; }
		public Unit? Unit { get; set; }
	}
}
