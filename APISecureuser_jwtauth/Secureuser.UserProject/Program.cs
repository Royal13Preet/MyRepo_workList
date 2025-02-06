using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using secureuser.Manager;
using Secureuser.DataAccess;
using Secureuser.DataAccess.Repositories;
using Secureuser.Manager;
using Secureuser.Models;
using Secureuser.Services;
using Secureuser.UserProject;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Register DbContext for Dependency Injection
builder.Services.AddDbContext<ProjectDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Register repository and service
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserManager, UserManager>();

builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddMemoryCache();

// Add Swagger with JWT Bearer Token support
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter your token as 'Bearer <JWT Token>'",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
});

// Add AutoMapper
builder.Services.AddAutoMapper(typeof(Program));

// Configure authentication & authorization
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "YourIssuer",
        ValidAudience = "YourAudience",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("YourLongerSecureSecretKeyHere12345"))
    };
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", policy =>
        policy.RequireRole("admin"));
});



builder.Services.AddLogging();
builder.Services.AddScoped<LoggingActionFilter>();
builder.Services.AddScoped<ErrorHandlerFilterAttribute>();

// Build the app
var app = builder.Build();

// Middleware for logging request
app.UseMiddleware<RequestLoggingMiddleware>();

// If in development, add Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Session middleware (add this after routing)
app.UseHttpsRedirection();
app.UseRouting();

// Authentication and Authorization middleware
app.UseAuthentication();
app.UseAuthorization();

// Enable session management
app.UseSession();

// Map controllers
app.MapControllers();

// Run the app
app.Run();
//builder.Services.AddControllersWithViews(options =>
//{
//    options.Filters.Add<LoggingActionFilter>();
//});