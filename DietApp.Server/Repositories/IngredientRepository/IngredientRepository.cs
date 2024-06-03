using DietApp.Server.models;

namespace DietApp.Server.Repositories.IngredientRepository
{
	public class IngredientRepository : IIngredientRepository
	{
		public Task<Ingredient> CrateIngredientAsync(Ingredient ingredient)
		{
			throw new NotImplementedException();
		}

		public Task<int> DeleteIngredientAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<Ingredient> GetIngredientByIdAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<List<Ingredient>> GetIngredientsAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<int> UpdateIngredientAsync(Guid id, Ingredient ingredient)
		{
			throw new NotImplementedException();
		}
	}
}
