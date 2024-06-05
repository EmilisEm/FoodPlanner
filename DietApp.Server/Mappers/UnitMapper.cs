using DietApp.Server.Dtos.UnitDtos;
using DietApp.Server.models;

namespace DietApp.Server.Mappers
{
	public static class UnitMapper
	{
		public static UnitResponseDto ToDto(Unit unit)
		{
			return new UnitResponseDto()
			{
				Id = unit.Id,
				Name = unit.Name,
			};
		}

		public static Unit FromDto(UnitChangeRequestDto unit)
		{
			return new Unit()
			{
				Id = Guid.NewGuid(),
				Name = unit.Name,
			};
		}

		public static Unit FromDto(UnitRequestDto unit)
		{
			return new Unit()
			{
				Id = unit.Id,
				Name = unit.Name,
			};
		}

		public static Unit FromDto(UnitChangeRequestDto unit, Guid id)
		{
			return new Unit()
			{
				Id = id,
				Name = unit.Name,
			};
		}

		public static Unit FromDto(UnitRequestDto unit, Guid id)
		{
			return new Unit()
			{
				Id = id,
				Name = unit.Name,
			};
		}
	}
}
