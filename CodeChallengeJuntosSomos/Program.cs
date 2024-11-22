using CodeChallengeJuntosSomos.Borders.Repositories;
using CodeChallengeJuntosSomos.Borders.UseCases;
using CodeChallengeJuntosSomos.Repositories;
using CodeChallengeJuntosSomos.UseCase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEmpresaUseCase, EmpresaUseCase>();
builder.Services.AddScoped<IEmpresaRepository,EmpresaRepository>();

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
