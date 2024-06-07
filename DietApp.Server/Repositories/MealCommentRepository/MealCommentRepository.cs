using DietApp.Server.Data;
using DietApp.Server.Exceptions;
using DietApp.Server.models;
using Microsoft.EntityFrameworkCore;

namespace DietApp.Server.Repositories.MealCommentRepository
{
	public class MealCommentRepository : IMealCommentRepository
	{
		private readonly DietAppDbContex _context;
		private readonly string MEAL_COMMENT_NOT_FOUND = "Meal comment not found";

		public MealCommentRepository(DietAppDbContex context)
		{
			_context = context;
		}

		public async Task<MealComment> CrateMealCommentAsync(MealComment mealComment)
		{
			_context.Add(mealComment);
			await _context.SaveChangesAsync();
			
			return mealComment;
		}

		public async Task<int> DeleteMealCommentAsync(Guid id)
		{
			MealComment? comment = await _context.MealsComment.FirstOrDefaultAsync(comment => comment.Id == id);
			
			if (comment == null)
			{
				throw new EntityNotFoundException(MEAL_COMMENT_NOT_FOUND);
			}
			_context.Remove(comment);
			return await _context.SaveChangesAsync();
		}

		public Task<MealComment?> GetMealCommentByIdAsync(Guid id)
		{
			return _context.MealsComment.FirstOrDefaultAsync(comment => comment.Id == id);
		}

		public async Task<IEnumerable<MealComment>> GetMealCommentsByMealIdAsync(Guid id)
		{
			return await _context.MealsComment.Where(comment => comment.MealId ==  id).ToListAsync();
		}

		public async Task<int> UpdateMealCommentAsync(Guid id, MealComment mealItem)
		{
			MealComment? original = await _context.MealsComment.FirstOrDefaultAsync(comment => comment.Id == id);

			if (original == null)
			{
				throw new EntityNotFoundException(MEAL_COMMENT_NOT_FOUND);
			}
			
			_context.Entry(original).CurrentValues.SetValues(mealItem);
			return await _context.SaveChangesAsync();
		}
	}
}
