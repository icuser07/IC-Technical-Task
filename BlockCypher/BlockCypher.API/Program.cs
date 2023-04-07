using BlockCypher.API.Extensions;
using BlockCypher.API.Middlewares;
using BlockCypher.Application.Handlers.QueryHandlers;
using BlockCypher.Domain.Interfaces;
using BlockCypher.Infrastructure.ApiClients.BlockCypher;
using BlockCypher.Infrastructure.Persistence;
using BlockCypher.Infrastructure.Persistence.Repositories;
using MediatR;
using BlockCypher.Application.Behaviors;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly, typeof(GetBlockchainInfoByNameHandler).Assembly);
});

builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));

builder.Services.AddValidatorsFromAssembly(typeof(BlockCypher.Application.Commands.CreateBlockchainInfoCommand).Assembly,
    includeInternalTypes: true);

builder.Services.AddTransient<LoggingMiddleware>();

builder.Services.AddDbContext<BlockCypherDbContext>();

builder.Services.AddHttpClient();

builder.Services.AddTransient<IBlockCypherClient, BlockCypherClient>();
builder.Services.AddScoped<IBlockchainRepository,BlockchainRepository> ();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Logging Middleware
app.UseLogging();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();