using DietApp.Server.models;

namespace DietApp.Server.Repositories.UnitRepository
{
	public class UnitRepository : IUnitRepository
	{
		public Task<Unit> CrateUnitAsync(Unit unit)
		{
			throw new NotImplementedException();
		}

		public Task<int> DeleteUnitAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<Unit> GetUnitByIdAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<List<Unit>> GetUnitsAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<int> UpdateUnitAsync(Guid id, Unit unit)
		{
			throw new NotImplementedException();
		}
	}
}
