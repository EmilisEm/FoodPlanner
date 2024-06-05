using DietApp.Server.Dtos.UnitDtos;
using DietApp.Server.Services.UnitService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DietApp.Server.Controllers
{
	[Route("api/v1/units")]
	[ApiController]
	public class UnitsController : ControllerBase
	{
		private readonly IUnitService _unitService;
		public UnitsController(IUnitService unitService)
		{
			_unitService = unitService;
		}
		
		[HttpGet("{id}")]
		public async Task<IActionResult> GetUnit(Guid id)
		{
			UnitResponseDto unit = await _unitService.GetUnitAsync(id); 
			return Ok(unit);
		}

		[HttpGet]
		public async Task<IActionResult> GetUnits()
		{
			List<UnitResponseDto> units = await _unitService.GetUnitsAsync(); 
			return Ok(units);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateUnit(Guid id, UnitChangeRequestDto newUnit)
		{
			await _unitService.UpdateUnitAsync(id, newUnit);
			return NoContent();
		}

		[HttpPost]
		public async Task<IActionResult> CreateUnit(UnitChangeRequestDto newUnit)
		{
			UnitResponseDto unit = await _unitService.CreateUnitAsync(newUnit);
			return CreatedAtAction(nameof(CreateUnit), unit);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteUnit(Guid id)
		{
			await _unitService.DeleteUnitAsync(id); 
			return NoContent();
		}
	}
}
