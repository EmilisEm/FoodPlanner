using DietApp.Server.Dtos.UnitDtos;

namespace DietApp.Server.Services.UnitService
{
	public interface IUnitService
	{
		public Task<UnitResponseDto> GetUnitAsync(Guid id);
		public Task<IEnumerable<UnitResponseDto>> GetUnitsAsync();
		public Task<UnitResponseDto> CreateUnitAsync(UnitChangeRequestDto unitRequestDto);
		public Task DeleteUnitAsync(Guid id);
		public Task UpdateUnitAsync(Guid id, UnitChangeRequestDto unitRequestDto);
	}
}
