using DietApp.Server.Dtos.IngredientDtos;
using DietApp.Server.Services.IngredientService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DietApp.Server.Controllers
{
	[Route("api/v1/ingredients")]
	[ApiController]
	public class IngredientsController : ControllerBase
	{
		private readonly IIngredientService _ingredientService;
		public IngredientsController(IIngredientService ingredientService) 
		{
			_ingredientService = ingredientService;
		}

		[HttpGet("/{id}")]
		public async Task<IActionResult> GetIngredient(Guid id)
		{
			IngredientResponseDto ingredient = await _ingredientService.GetIngredientAsync(id);

			return Ok(ingredient);
		}

		[HttpGet]
		public async Task<IActionResult> GetIngredients()
		{
			List<IngredientResponseDto> ingredients = await _ingredientService.GetIngredientsAsync();

			return Ok(ingredients);
		}

		[HttpDelete("/{id}")]
		public async Task<IActionResult> DeleteIngredient(Guid id)
		{
			 await _ingredientService.DeleteIngredientAsync(id);

			return NoContent();
		}

		[HttpPost]
		public async Task<IActionResult> CreateIngredient(IngredientRequestDto newIngredient)
		{
			 IngredientResponseDto ingredient = await _ingredientService.CreateIngredientAsync(newIngredient);

			return CreatedAtAction(nameof(CreateIngredient), ingredient);
		}

		[HttpPut("/{id}")]
		public async Task<IActionResult> UpdateIngredient(Guid id, IngredientRequestDto updatedIngredient)
		{
			 await _ingredientService.UpdateIngredientAsync(id, updatedIngredient);

			return NoContent();
		}
	}
}
