using Microsoft.EntityFrameworkCore;
using MusicApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

//Database connection
builder.Services.AddDbContext<SongContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("DefaultDbString")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
