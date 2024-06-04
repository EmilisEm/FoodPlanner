using DietApp.Server.Dtos.UnitDtos;
using DietApp.Server.Mappers;
using DietApp.Server.models;
using DietApp.Server.Repositories.UnitRepository;

namespace DietApp.Server.Services.UnitService
{
	public class UnitService : IUnitService
	{
		private readonly IUnitRepository _unitRepository;

		public UnitService (IUnitRepository unitRepository)
		{
			_unitRepository = unitRepository;
		}

		public async Task<UnitResponseDto> CreateUnitAsync(UnitRequestDto unitRequestDto)
		{
			Unit unit = UnitMapper.FromDto(unitRequestDto);
			await _unitRepository.CrateUnitAsync(unit);

			return UnitMapper.ToDto(unit);
		}

		public async Task DeleteUnitAsync(Guid id)
		{
			int deletedCount = await _unitRepository.DeleteUnitAsync(id);

			if (deletedCount < 1) 
			{
				// TODO: make custom exception
				throw new Exception("Unit not found");
			}
		}

		public async Task<UnitResponseDto> GetUnitAsync(Guid id)
		{
			Unit? unit = await _unitRepository.GetUnitByIdAsync(id);

			if (unit == null)
			{
				// TODO: Not found exception
				throw new Exception("Unit not found");
			}

			return UnitMapper.ToDto(unit);
		}

		public async Task<List<UnitResponseDto>> GetUnitsAsync()
		{
			List<Unit> units = await _unitRepository.GetUnitsAsync();

			return units.Select(UnitMapper.ToDto).ToList();
		}

		public async Task UpdateUnitAsync(Guid id, UnitRequestDto unitRequestDto)
		{
			Unit original = await _unitRepository.GetUnitByIdAsync(id);

			if (original == null)
			{
				throw new Exception("Unit not found");
			}

			int count = await _unitRepository.UpdateUnitAsync(id, UnitMapper.FromDto(unitRequestDto, id));

			if (count < 1)
			{
				throw new Exception("Failed to update unit");
			}
		}
	}
}
