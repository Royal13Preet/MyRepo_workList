using Microsoft.EntityFrameworkCore;
using Saturday_ManagingProducts;
using Saturday_ManagingProducts.DataAccess;
using Saturday_ManagingProducts.DataAccess.Repositories;
using Saturday_ManagingProducts.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddScoped(typeof(IProductService), typeof(ProductService));



// Add services to the container.
//builder.Services.AddDbContext<>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseMiddleware<LoggingMiddleware>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
