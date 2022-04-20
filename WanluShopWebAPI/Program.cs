using Microsoft.EntityFrameworkCore;
using WanluShopWebAPI.Models;

var builder = WebApplication.CreateBuilder(args);
// Connection String
string strConn = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\ASUS\\source\\repos\\WanluShopWebAPI\\WanluShopWebAPI\\DB\\WanluClothDB.mdf; Integrated Security = True; Connect Timeout = 30";

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<WanluShopWebAPI.Models.WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext>(options => options.UseSqlServer(strConn));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
