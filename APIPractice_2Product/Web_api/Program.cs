using DataAccess;
using DataAccess.Repository;
using Manager_layer;
using Microsoft.EntityFrameworkCore;
using Service_Layer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataBaseApprochContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.

builder.Services.AddTransient<IRepository, Repository>();
builder.Services.AddTransient<IManager, Manager>();
builder.Services.AddTransient<IService, Service>();

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
