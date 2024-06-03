using DietApp.Server.Data;
using DietApp.Server.Repositories.IngredientRepository;
using DietApp.Server.Repositories.IngredientUnitRepository;
using DietApp.Server.Repositories.MealCommentRepository;
using DietApp.Server.Repositories.MealItemRepository;
using DietApp.Server.Repositories.MealRepository;
using DietApp.Server.Repositories.UnitRepository;
using DietApp.Server.Services.IngredientService;
using DietApp.Server.Services.MealCommentService;
using DietApp.Server.Services.MealService;
using DietApp.Server.Services.UnitService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DietAppDbContex>(options => options.UseNpgsql(connectionString));

builder.Services.AddScoped<IIngredientRepository, IngredientRepository>();
builder.Services.AddScoped<IIngredientUnitRepository, IngredientUnitRepository>();
builder.Services.AddScoped<IMealCommentRepository, MealCommentRepository>();
builder.Services.AddScoped<IMealItemRepository, MealItemRepository>();
builder.Services.AddScoped<IMealRepository, MealRepository>();
builder.Services.AddScoped<IUnitRepository, UnitRepository>();
builder.Services.AddScoped<IIngredientService, IngredientService>();
builder.Services.AddScoped<IMealCommentService, MealCommentService>();
builder.Services.AddScoped<IMealService, MealService>();
builder.Services.AddScoped<IUnitService, UnitService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<DietAppDbContex>();
        context.Database.Migrate();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while migrating the database.");
    }
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
