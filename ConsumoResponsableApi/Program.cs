using ConsumoResponsableApi.Application.Repositories.Implementation;
using ConsumoResponsableApi.Application.Repositories.Interface.Base;
using ConsumoResponsableApi.Application.Services.Implementation;
using ConsumoResponsableApi.Application.Services.Interface.Base;
using ConsumoResponsableApi.Domain.Entities;
using ConsumoResponsableApi.Domain.Models.Consumption.RepositoryFilters;
using ConsumoResponsableApi.Domain.Models.Consumption.Request;
using ConsumoResponsableApi.Domain.Models.Consumption.Response;
using ConsumoResponsableApi.Infrastructure.Persistence;
using ConsumoResponsableApi.Middlewares;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ErrorHandlingMiddleware>(); 

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("EagleHubsDatabase")));

//Services Injections
builder.Services.AddScoped<IServicePost<PostFuelConsumptionRequest, PostDefaultConsumptionResponse>, ConsumptionService>();
builder.Services.AddScoped<IServicePost<PostEnergyConsumptionRequest, PostDefaultConsumptionResponse>, ConsumptionService>();
builder.Services.AddScoped<IServicePost<PostOtherConsumptionRequest, PostDefaultConsumptionResponse>, ConsumptionService>();
builder.Services.AddScoped<IServicePost<PostTravelConsumptionRequest, PostDefaultConsumptionResponse>, ConsumptionService>();
builder.Services.AddScoped<IServicePut<PutConsumptionRequest, PostDefaultConsumptionResponse>, ConsumptionService>();

//Repositories Injections
builder.Services.AddScoped<IRepositoryPost<Consumption, Consumption>, ConsumptionRepository>();
builder.Services.AddScoped<IRepositoryPut<Consumption>, ConsumptionRepository>();
builder.Services.AddScoped<IRepositoryGetById<GetConsumptionByIdRequest, Consumption>, ConsumptionRepository>();

builder.Services.AddScoped<IRepositoryGetAll<ConsumptionType>, ConsumptionTypeRepository>();
builder.Services.AddScoped<IRepositoryGetAll<Location>, LocationsRepository>();


var app = builder.Build();

app.UseMiddleware<ErrorHandlingMiddleware>();

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
