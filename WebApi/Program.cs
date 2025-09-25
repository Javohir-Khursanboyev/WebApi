var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer(); // OpenAPI endpoint yaratadi
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();          
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();
