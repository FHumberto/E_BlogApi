using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Serilog;
using T_Tier.API.Extensions;
using T_Tier.API.Middlewares;
using T_Tier.BLL;
using T_Tier.BLL.Settings;
using T_Tier.DAL;
using T_Tier.DAL.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection(nameof(JwtSettings)));
builder.Services.AddSingleton(sp => sp.GetRequiredService<IOptions<JwtSettings>>().Value);
builder.Services.RegisterBLLDependencies(builder.Configuration);
builder.Services.RegisterDALDependencies(builder.Configuration);
builder.Services.AddExceptionHandler<GlobalExceptionMiddleware>();
builder.Services.AddCorsPolicies();
builder.Services.AddProblemDetails();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerRoutes();
builder.Services.AddSwaggerAuthServices();
builder.Services.AddAuthenticationServices(builder.Configuration);

var app = builder.Build();

app.UseCorsPolicies();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();
    //? não é uma boa prática, mas usado aqui para um ambiente de teste.
    context.Database.Migrate();
}

//? chama o logger depois do banco criado
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .ReadFrom.Services(app.Services)
    .Enrich.FromLogContext()
    .CreateLogger();

if (app.Environment.IsDevelopment())
{
    _ = app.UseSwaggerWithVersioning();
}

app.UseHttpsRedirection();
app.UseExceptionHandler();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();