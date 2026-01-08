using Microsoft.EntityFrameworkCore;
using SistemaTaller.API.Extensions;
using SistemaTaller.DataAccess;
using SistemaTaller.BussinesLogic;
using SistemaTaller.DataAccess.SistemaTallerContext;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SistemaTallerConn");
builder.Services.AddDbContext<DbTallerContext>(option => option.UseSqlServer(connectionString));


builder.Services.DataAccess(connectionString);
builder.Services.BusinessLogic();

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(typeof(MappingProfileExtensions));
});

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