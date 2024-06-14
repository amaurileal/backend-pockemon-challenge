using backend_pokemon_challenge.infrastructure.Extensions;
using backend_pokemon_challenge.api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddPresentation();
builder.Services.AddInfrastructure(builder.Configuration);

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
