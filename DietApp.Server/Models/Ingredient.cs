using System.ComponentModel.DataAnnotations;
using DietApp.Server.Models;

namespace DietApp.Server.models
{
	public class Ingredient
	{
		[Key] public Guid Id { get; set; }
		[Required] public required string Name { get; set; }
		public List<IngredientUnit>? Units {  get; set; } 
	}
}
