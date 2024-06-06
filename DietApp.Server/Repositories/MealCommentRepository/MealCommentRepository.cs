using DietApp.Server.Data;
using DietApp.Server.models;
using Microsoft.EntityFrameworkCore;

namespace DietApp.Server.Repositories.MealCommentRepository
{
	public class MealCommentRepository : IMealCommentRepository
	{
		private readonly DietAppDbContex _context;

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
				// TODO: Exceptions
				throw new Exception("Failed to find meal comment");
			}
			_context.Remove(comment);
			return await _context.SaveChangesAsync();
		}

		public Task<MealComment?> GetMealCommentByIdAsync(Guid id)
		{
			return _context.MealsComment.FirstOrDefaultAsync(comment => comment.Id == id);
		}

		public async Task<List<MealComment>> GetMealCommentsByMealIdAsync(Guid id)
		{
			return await _context.MealsComment.Where(comment => comment.MealId ==  id).ToListAsync();
		}

		public async Task<int> UpdateMealCommentAsync(Guid id, MealComment mealItem)
		{
			MealComment? original = await _context.MealsComment.FirstOrDefaultAsync(comment => comment.Id == id);

			if (original == null)
			{
				// TODO: Exceptions
				throw new Exception("Meal comment not found");
			}
			
			_context.Entry(original).CurrentValues.SetValues(mealItem);
			return await _context.SaveChangesAsync();
		}
	}
}
