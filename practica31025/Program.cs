using Microsoft.EntityFrameworkCore;
using practica31025.Model;
using practica31025.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddSingleton(new List<Food>
//{
//    new Food { Id = 1, Name = "guineo", Description = TypeFood.Fruits },
//    new Food { Id = 2, Name = "pitahaya", Description = TypeFood.Fruits },
//    new Food { Id = 3, Name = "lechuga", Description = TypeFood.Vegetables }
//});

builder.Services.AddDbContext<FoodContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<FoodServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
