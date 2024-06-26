﻿using DietApp.Server.models;

namespace DietApp.Server.Repositories.MealRepository
{
	public interface IMealRepository
	{
		public Task<Meal?> GetMealByIdAsync(Guid id);
		public Task<IEnumerable<Meal>> GetMealsAsync();
		public Task<Meal> CrateMealAsync(Meal meal);
		public Task<int> UpdateMealAsync(Guid id, Meal meal);
		public Task<int> DeleteMealAsync(Guid id);
	}
}
