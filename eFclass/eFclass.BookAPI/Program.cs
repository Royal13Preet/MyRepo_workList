using eFclass.DataAccess;
using eFclass.DataAccess.Repository;
using eFclass.Managers;
using eFclass.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IBook, BookRepo>();
builder.Services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));
builder.Services.AddTransient<IBookManager, BookManager>();
builder.Services.AddTransient<IUserManager, UserManager>();
builder.Services.AddTransient<IBookService, BookService>();
builder.Services.AddTransient<IUserService, UserService>();

builder.Services.AddDbContext<BookContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection")));

// Add SQLite context with SQLite connection string
builder.Services.AddDbContext<SqlLiteBookDataContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SQLiteConnection")));



builder.Services.AddDbContext<BookContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//add automapper
builder.Services.AddAutoMapper(typeof(Program));
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
