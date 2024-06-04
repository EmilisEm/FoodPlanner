using DietApp.Server.Data;
using DietApp.Server.models;
using Microsoft.EntityFrameworkCore;

namespace DietApp.Server.Repositories.UnitRepository
{
	public class UnitRepository : IUnitRepository
	{
		private readonly DietAppDbContex _context;

		public UnitRepository(DietAppDbContex context)
		{
			_context = context;
		}

		public async Task<Unit> CrateUnitAsync(Unit unit)
		{
			await _context.AddAsync(unit);
			await _context.SaveChangesAsync();

			return unit;
		}

		public async Task<int> DeleteUnitAsync(Guid id)
		{
			Unit? unit = await _context.Unit.FirstOrDefaultAsync(unit => unit.Id == id);
			if (unit == null)
			{
				throw new Exception("Unit not found");
			}

			_context.Unit.Remove(unit);
			return await _context.SaveChangesAsync();
		}

		public async Task<Unit?> GetUnitByIdAsync(Guid id)
		{
			return await _context.Unit.FirstOrDefaultAsync(unit => unit.Id == id);
		}

		public async Task<List<Unit>> GetUnitsAsync()
		{
			return await _context.Unit.ToListAsync();
		}

		public async Task<int> UpdateUnitAsync(Guid id, Unit unit)
		{
			Unit? original = await _context.Unit.FirstOrDefaultAsync(unit => unit.Id == id);

			if (original == null)
			{
				throw new Exception("Unit not found");
			}
			
			unit.Id = id;
			_context.Entry(original).CurrentValues.SetValues(unit);
			return await _context.SaveChangesAsync();
		}
	}
}
