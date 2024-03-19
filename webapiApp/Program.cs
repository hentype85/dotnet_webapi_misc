using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using webapiApp.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure database string connection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    string cnn = builder.Configuration.GetConnectionString("MiBaseDeDatos");
    options.UseMySQL(cnn);
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Add CORS configuration
builder.Services.AddCors();
app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
    // builder.WithOrigins("http://127.0.0.1:5500")
           .AllowAnyHeader()
           .AllowAnyMethod();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
