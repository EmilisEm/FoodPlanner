using DietApp.Server.Dtos.UnitDtos;

namespace DietApp.Server.Services.UnitService
{
	public class UnitService : IUnitService
	{
		public Task<UnitResponseDto> CreateUnitAsync(UnitRequestDto unitRequestDto)
		{
			throw new NotImplementedException();
		}

		public Task DeleteUnitAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<UnitResponseDto> GetUnitAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<List<UnitResponseDto>> GetUnitsAsync()
		{
			throw new NotImplementedException();
		}

		public Task UpdateUnitAsync(Guid id, UnitRequestDto unitRequestDto)
		{
			throw new NotImplementedException();
		}
	}
}
