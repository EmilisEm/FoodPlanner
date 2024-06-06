using DietApp.Server.Dtos.MealCommentDtos;
using DietApp.Server.Mappers;
using DietApp.Server.models;
using DietApp.Server.Repositories.MealCommentRepository;

namespace DietApp.Server.Services.MealCommentService
{
	public class MealCommentService : IMealCommentService
	{
		private readonly IMealCommentRepository _mealCommentRepository;

		public MealCommentService(IMealCommentRepository mealCommentRepository)
		{
			_mealCommentRepository = mealCommentRepository;
		}

		public async Task<MealCommentResponseDto> CreateMealCommentAsync(MealCommentRequestDto mealCommentRequestDto)
		{
			MealComment comment = MealCommentMapper.FromDto(mealCommentRequestDto);
			await _mealCommentRepository.CrateMealCommentAsync(comment);

			return MealCommentMapper.ToDto(comment);
		}

		public async Task DeleteMealCommentAsync(Guid id)
		{
			await _mealCommentRepository.DeleteMealCommentAsync(id);
		}

		public async Task<MealCommentResponseDto> GetMealCommentAsync(Guid id)
		{
			MealComment? comment = await _mealCommentRepository.GetMealCommentByIdAsync(id);

			if (comment == null)
			{
				// TODO: Exceptions
				throw new Exception("Meal comment not found");
			}

			return MealCommentMapper.ToDto(comment);
		}

		public async Task<List<MealCommentResponseDto>> GetMealCommentsByMealIdAsync(Guid id)
		{
			IEnumerable<MealComment> meals = await _mealCommentRepository.GetMealCommentsByMealIdAsync(id);

			return meals.Select(meal => MealCommentMapper.ToDto(meal)).ToList();
		}

		public async Task UpdateMealCommentAsync(Guid id, MealCommentRequestDto mealCommentRequestDto)
		{
			MealComment comment = MealCommentMapper.FromDto(id, mealCommentRequestDto);

			await _mealCommentRepository.UpdateMealCommentAsync(id, comment);
		}
	}
}
