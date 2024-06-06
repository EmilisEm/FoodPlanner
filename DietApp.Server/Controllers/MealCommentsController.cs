using DietApp.Server.Dtos.MealCommentDtos;
using DietApp.Server.Services.MealCommentService;
using Microsoft.AspNetCore.Mvc;

namespace DietApp.Server.Controllers
{
	[Route("api/v1/meal-comments")]
	[ApiController]
	public class MealCommentsController : ControllerBase
	{
		private readonly IMealCommentService _mealCommentService;
		public MealCommentsController(IMealCommentService mealCommentService)
		{ 
			_mealCommentService = mealCommentService;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetMealComment(Guid id)
		{
			MealCommentResponseDto comment = await _mealCommentService.GetMealCommentAsync(id);

			return Ok(comment);
		}

		[HttpGet("by-meal/{mealId}")]
		public async Task<IActionResult> GetMealCommentsByMealId(Guid mealId)
		{
			IEnumerable<MealCommentResponseDto> comments = await _mealCommentService.GetMealCommentsByMealIdAsync(mealId);

			return Ok(comments);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteMealComment(Guid id)
		{
			await _mealCommentService.DeleteMealCommentAsync(id);

			return NoContent();
		}

		[HttpPost]
		public async Task<IActionResult> CreateMealComment(MealCommentRequestDto mealComment)
		{
			MealCommentResponseDto comment = await _mealCommentService.CreateMealCommentAsync(mealComment);

			return Ok(comment);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateMealComment(Guid id, MealCommentRequestDto mealComment)
		{
			await _mealCommentService.UpdateMealCommentAsync(id, mealComment);

			return NoContent();
		}
	}
}
