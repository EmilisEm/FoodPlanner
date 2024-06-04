using DietApp.Server.Models;

namespace DietApp.Server.Repositories.IngredientUnitRepository
{
	public interface IIngredientUnitRepository
	{
		public Task<IngredientUnit?> GetIngredientUnitByIdAsync(Guid id);
		public Task<List<IngredientUnit>> GetIngredientUnitsByIngredientIdAsync(Guid id);
		public Task<IngredientUnit> CrateIngredientUnitAsync(IngredientUnit ingredient);
		public Task<int> UpdateIngredientUnitAsync(Guid id, IngredientUnit ingredient);
		public Task<int> DeleteIngredientUnitAsync(Guid id);
	}
}
