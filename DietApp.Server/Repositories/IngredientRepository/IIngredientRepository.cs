using DietApp.Server.models;

namespace DietApp.Server.Repositories.IngredientRepository
{
	public interface IIngredientRepository
	{
		public Task<Ingredient?> GetIngredientByIdAsync(Guid id);
		public Task<IEnumerable<Ingredient>> GetIngredientsAsync();
		public Task<Ingredient> CrateIngredientAsync(Ingredient ingredient);
		public Task<int> UpdateIngredientAsync(Guid id, Ingredient ingredient);
		public Task<int> DeleteIngredientAsync(Guid id);
	}
}
