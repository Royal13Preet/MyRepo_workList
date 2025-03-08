
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Thursday_ProductManagement.DataAccess;
using Thursday_ProductManagement.DataAccess.Repositories;
using Thursday_ProductManagement.Filters;
using Thursday_ProductManagement.Managers;
using Thursday_ProductManagement.Services;
using Thursday_ProductManagement.WebApi;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(5033); // HTTP
    serverOptions.ListenAnyIP(7208, listenOptions => listenOptions.UseHttps()); // HTTPS
});

IConfiguration configuration = builder.Configuration;

builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped(typeof(IProductManager), typeof(ProductManager));
builder.Services.AddScoped(typeof(IProductService), typeof(ProductService));
builder.Services.AddAutoMapper(typeof(Program));

//// Add controllers and Swagger for API
builder.Services.AddControllers();



// Configure session management
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});



//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowSpecificOrigin", policy =>
//    {
//        policy.WithOrigins("https://example.com")
//        .AllowAnyHeader()
//        .AllowAnyMethod();
//    });
//});


// Add memory cache
builder.Services.AddMemoryCache();

// Add logging
builder.Services.AddLogging();

// Add custom action filter
builder.Services.AddScoped<ValidateActionFilter>();

builder.Services.AddEndpointsApiExplorer();

// Add Basic Authentication
builder.Services.AddAuthentication("Basic")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("Basic", null);

builder.Services.AddAuthorizationBuilder()
    .AddPolicy("AdminPolicy", policy =>
        policy.RequireRole("Admin"));


// Configure Swagger with Basic Authentication
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Basic", new OpenApiSecurityScheme
    {
        Description = "Enter your username and password to access the API",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "Basic"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Basic"
                }
            },
            new string[] { }
        }
    });
});

var app = builder.Build();


app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
// Enable Swagger UI in development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSession();
app.UseMiddleware<LoggingMiddleware>();
app.UseCors();
app.UseHttpsRedirection();
app.UseAuthentication();



app.UseAuthorization();

app.MapControllers();

app.Run();



public partial class Program { }