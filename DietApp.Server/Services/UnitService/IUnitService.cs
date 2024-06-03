using DietApp.Server.Dtos.UnitDtos;

namespace DietApp.Server.Services.UnitService
{
	public interface IUnitService
	{
		public Task<UnitResponseDto> GetUnitAsync(Guid id);
		public Task<List<UnitResponseDto>> GetUnitsAsync();
		public Task<UnitResponseDto> CreateUnitAsync(UnitRequestDto unitRequestDto);
		public Task DeleteUnitAsync(Guid id);
		public Task UpdateUnitAsync(Guid id, UnitRequestDto unitRequestDto);
	}
}
