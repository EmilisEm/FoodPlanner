﻿using DietApp.Server.models;

namespace DietApp.Server.Repositories.UnitRepository
{
	public interface IUnitRepository
	{
		public Task<Unit?> GetUnitByIdAsync(Guid id);
		public Task<IEnumerable<Unit>> GetUnitsAsync();
		public Task<Unit> CrateUnitAsync(Unit unit);
		public Task<int> UpdateUnitAsync(Guid id, Unit unit);
		public Task<int> DeleteUnitAsync(Guid id);
	}
}
