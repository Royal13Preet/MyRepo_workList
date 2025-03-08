using API_DataAccessLayer;
using API_DataAccessLayer.Repositories;
using API_manager;
using API_Servicelayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
    

// Add services to the container.
builder.Services.AddTransient<IUserRepo, UserRepo>();
builder.Services.AddTransient<IUserManager, UserManger>();
builder.Services.AddTransient<IUserService, UserService>();

builder.Services.AddTransient<IProfileRepo, ProfileRepo>();
builder.Services.AddTransient<IProfileManager, ProfileManager>();
builder.Services.AddTransient<IProfileService, ProfileService>();

builder.Services.AddTransient<ISkillRepo, SkillRepo>();
builder.Services.AddTransient<ISkillManager, SkillManager>();
builder.Services.AddTransient<ISkillService, SkillService>();

builder.Services.AddTransient<IProjectRepo, ProjectRepo>();
builder.Services.AddTransient<IProjectManager, ProjectManager>();
builder.Services.AddTransient<IProjectService, ProjectService>();


builder.Services.AddTransient<IUserSkillRepo, UserSkillRepo>();
builder.Services.AddTransient<IUserSkillService, UserSkillService>();


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
