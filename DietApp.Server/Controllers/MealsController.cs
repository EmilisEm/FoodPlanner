using DietApp.Server.Dtos.MealDtos;
using DietApp.Server.Services.MealService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DietApp.Server.Controllers
{
	[Route("api/v1/meals")]
	[ApiController]
	public class MealsController : ControllerBase
	{
		private readonly IMealService _mealService;
		public MealsController(IMealService mealService) 
		{ 
			_mealService = mealService;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetMeal(Guid id) 
		{
			MealResponseDto meal = await _mealService.GetMealAsync(id);

			return Ok(meal);
		}

		[HttpGet]
		public async Task<IActionResult> GetMeals() 
		{
			List<MealResponseDto> meals = await _mealService.GetMealsAsync();

			return Ok(meals);
		}

		[HttpPost]
		public async Task<IActionResult> CreateMeal(MealRequestDto mealRequestDto) 
		{
			MealResponseDto meal = await _mealService.CreateMealAsync(mealRequestDto);

			return CreatedAtAction(nameof(CreateMeal), meal);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateMeal(Guid id, MealRequestDto mealRequestDto) 
		{
			await _mealService.UpdateMealAsync(id, mealRequestDto);

			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteMeal(Guid id) 
		{
			await _mealService.DeleteMealAsync(id);

			return NoContent();
		}
	}
}
