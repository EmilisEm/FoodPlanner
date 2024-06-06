using DietApp.Server.Dtos.IngredientDtos;
using DietApp.Server.Mappers;
using DietApp.Server.models;
using DietApp.Server.Repositories.IngredientRepository;

namespace DietApp.Server.Services.IngredientService
{
	public class IngredientService : IIngredientService
	{
		private readonly IIngredientRepository _ingredientRepository;

		public IngredientService(IIngredientRepository ingredientRepository)
		{
			_ingredientRepository = ingredientRepository;
		}

		public async Task<IngredientResponseDto> CreateIngredientAsync(IngredientRequestDto ingredientRequestDto)
		{
			Ingredient ingredient = IngredientMapper.FromDto(ingredientRequestDto);
			await _ingredientRepository.CrateIngredientAsync(ingredient);

			return IngredientMapper.ToDto(ingredient);
		}

		public async Task DeleteIngredientAsync(Guid id)
		{
			Ingredient? ingredient = await _ingredientRepository.GetIngredientByIdAsync(id);
			if (ingredient == null)
			{
				// TODO: Add not found exception
				throw new Exception("Failed to find Ingredient");
			}

			int count = await _ingredientRepository.DeleteIngredientAsync(id);
			if (count < 1)
			{
				throw new Exception("Failed to delete Ingredient");
			}
		}

		public async Task<IngredientResponseDto> GetIngredientAsync(Guid id)
		{
			Ingredient? ingredient = await  _ingredientRepository.GetIngredientByIdAsync(id);

			if (ingredient == null)
			{
				// TODO: make this generic
				throw new Exception("Failed to find Ingredient");
			}

			return IngredientMapper.ToDto(ingredient);
		}

		public async Task<IEnumerable<IngredientResponseDto>> GetIngredientsAsync()
		{
			return (await _ingredientRepository.GetIngredientsAsync()).Select(IngredientMapper.ToDto).ToList();
		}

		public async Task UpdateIngredientAsync(Guid id, IngredientRequestDto ingredientRequestDto)
		{
			Ingredient ingredient = IngredientMapper.FromDto(ingredientRequestDto, id);
			int count = await _ingredientRepository.UpdateIngredientAsync(id, ingredient);

			if (count < 1)
			{
				// TODO: You know
				throw new Exception("Failed to update Ingredient");
			}
		}
	}
}