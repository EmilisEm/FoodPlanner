using DietApp.Server.Dtos.UnitDtos;
using DietApp.Server.Exceptions;
using DietApp.Server.Mappers;
using DietApp.Server.models;
using DietApp.Server.Repositories.UnitRepository;

namespace DietApp.Server.Services.UnitService
{
	public class UnitService : IUnitService
	{
		private readonly IUnitRepository _unitRepository;
		private readonly string UNIT_NOT_FOUND = "Unit not found";

		public UnitService (IUnitRepository unitRepository)
		{
			_unitRepository = unitRepository;
		}

		public async Task<UnitResponseDto> CreateUnitAsync(UnitChangeRequestDto unitRequestDto)
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
				throw new EntityNotFoundException(UNIT_NOT_FOUND);
			}
		}

		public async Task<UnitResponseDto> GetUnitAsync(Guid id)
		{
			Unit? unit = await _unitRepository.GetUnitByIdAsync(id);

			if (unit == null)
			{
				throw new EntityNotFoundException(UNIT_NOT_FOUND);
			}

			return UnitMapper.ToDto(unit);
		}

		public async Task<IEnumerable<UnitResponseDto>> GetUnitsAsync()
		{
			IEnumerable<Unit> units = await _unitRepository.GetUnitsAsync();

			return units.Select(UnitMapper.ToDto).ToList();
		}

		public async Task UpdateUnitAsync(Guid id, UnitChangeRequestDto unitRequestDto)
		{
			Unit? original = await _unitRepository.GetUnitByIdAsync(id);

			if (original == null)
			{
				throw new EntityNotFoundException(UNIT_NOT_FOUND);
			}

			int count = await _unitRepository.UpdateUnitAsync(id, UnitMapper.FromDto(unitRequestDto, id));

			if (count < 1)
			{
				throw new EntityNotFoundException(UNIT_NOT_FOUND);
			}
		}
	}
}
