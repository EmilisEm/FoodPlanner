using DietApp.Server.Dtos.IngredientDtos;

namespace DietApp.Server.Services.IngredientService
{
	public interface IIngredientService
	{
		public Task<IngredientResponseDto> GetIngredientAsync(Guid id);
		public Task<List<IngredientResponseDto>> GetIngredientsAsync();
		public Task<IngredientResponseDto> CreateIngredientAsync(IngredientRequestDto ingredientRequestDto);
		public Task DeleteIngredientAsync(Guid id);
		public Task UpdateIngredientAsync(Guid id, IngredientRequestDto ingredientRequestDto);
	}
}
