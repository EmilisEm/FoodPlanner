using DietApp.Server.models;
using Microsoft.EntityFrameworkCore;

namespace DietApp.Server.Data
{
	public class DietAppDbContex : DbContext
	{
		public DbSet<WeatherForecast> WeatherForecasts { get; set; }
		public DbSet<Meal> Meals { get; set; }
		public DbSet<MealItem> MealsItem { get; set; }
		public DbSet<MealComment> MealsComment { get; set; }
		public DbSet<Ingredient> Ingredients { get; set; }
		public DbSet<Unit> Unit { get; set; }
		public DietAppDbContex(DbContextOptions<DietAppDbContex> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Ingredient>()
				.HasMany(ingreident => ingreident.Units)
				.WithMany(unit => unit.Ingredients);
		}
	}
}
