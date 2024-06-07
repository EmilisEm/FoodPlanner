using DietApp.Server.Dtos.MealDtos;
using DietApp.Server.Exceptions;
using DietApp.Server.Mappers;
using DietApp.Server.models;
using DietApp.Server.Repositories.MealRepository;

namespace DietApp.Server.Services.MealService
{
	public class MealService : IMealService
	{
		private readonly IMealRepository _mealRepository;
		private readonly string MEAL_NOT_FOUND = "Meal not found";

		public MealService(IMealRepository mealRepository)
		{
			_mealRepository = mealRepository;
		}

		public async Task<MealResponseDto> CreateMealAsync(MealRequestDto mealRequestDto)
		{
			Meal meal = MealMapper.FromDto(mealRequestDto);
			await _mealRepository.CrateMealAsync(meal);

			return MealMapper.ToDto(meal);
		}

		public async Task DeleteMealAsync(Guid id)
		{
			await _mealRepository.DeleteMealAsync(id);
		}

		public async Task<MealResponseDto> GetMealAsync(Guid id)
		{
			Meal? meal = await _mealRepository.GetMealByIdAsync(id);

			if (meal == null)
			{
				throw new EntityNotFoundException(MEAL_NOT_FOUND);
			}

			return MealMapper.ToDto(meal);
		}

		public async Task<IEnumerable<MealResponseDto>> GetMealsAsync()
		{
			return (await _mealRepository.GetMealsAsync())
				.Select(MealMapper.ToDto)
				.ToList();
		}

		public async Task UpdateMealAsync(Guid id, MealRequestDto mealRequestDto)
		{
			Meal meal = MealMapper.FromDto(mealRequestDto, id);

			await _mealRepository.UpdateMealAsync(id, meal);
		}
	}
}
