using DietApp.Server.Dtos.IngredientDtos;
using DietApp.Server.models;

namespace DietApp.Server.Mappers
{
	public static class IngredientMapper
	{
		public static IngredientResponseDto ToDto(Ingredient ingredient)
		{
			return new IngredientResponseDto()
			{
				Id = ingredient.Id,
				Name = ingredient.Name,
				Units = ingredient.Units.Select(UnitMapper.ToDto).ToList(),
			};
		}

		public static Ingredient FromDto(IngredientRequestDto ingredientRequest)
		{
			return new Ingredient()
			{
				Id = Guid.NewGuid(),
				Name = ingredientRequest.Name,
				Units = ingredientRequest.Units.Select(UnitMapper.FromDto).ToList(),
			};
		}

		public static Ingredient FromDto(IngredientRequestDto ingredientRequest, Guid id)
		{
			return new Ingredient()
			{
				Id = id,
				Name = ingredientRequest.Name,
				Units = ingredientRequest.Units.Select(UnitMapper.FromDto).ToList(),
			};
		}
	}
}
