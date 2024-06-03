using DietApp.Server.Dtos.IngredientDtos;

namespace DietApp.Server.Services.IngredientService
{
	public class IngredientService : IIngredientService
	{
		public Task<IngredientResponseDto> CreateIngredientAsync(IngredientRequestDto ingredientRequestDto)
		{
			throw new NotImplementedException();
		}

		public Task DeleteIngredientAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<IngredientResponseDto> GetIngredientAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<List<IngredientResponseDto>> GetIngredientsAsync()
		{
			throw new NotImplementedException();
		}

		public Task UpdateIngredientAsync(Guid id, IngredientRequestDto ingredientRequestDto)
		{
			throw new NotImplementedException();
		}
	}
}
