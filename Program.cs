using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Adicione os serviços necessários para os controladores
builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();

// Mapeia os controladores
app.MapControllers();

// Executa a aplicação na porta 5000
app.Run("http://localhost:5000");
