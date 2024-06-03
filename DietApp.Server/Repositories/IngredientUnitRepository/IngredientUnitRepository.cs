using DietApp.Server.Models;

namespace DietApp.Server.Repositories.IngredientUnitRepository
{
	public class IngredientUnitRepository : IIngredientUnitRepository
	{
		public Task<IngredientUnit> CrateIngredientUnitAsync(IngredientUnit ingredient)
		{
			throw new NotImplementedException();
		}

		public Task<int> DeleteIngredientUnitAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<IngredientUnit> GetIngredientUnitByIdAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<List<IngredientUnit>> GetIngredientUnitsByIngredientIdAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<int> UpdateIngredientUnitAsync(Guid id, IngredientUnit ingredient)
		{
			throw new NotImplementedException();
		}
	}
}
