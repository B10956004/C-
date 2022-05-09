using WebApplication2.Model;
using Microsoft.EntityFrameworkCore;
/// <summary>
///安裝兩種NuGet套件
///Microsoft.EntityFrameworkCore.InMemory
///Microsoft.EntityFrameworkCore.Design
/// </summary>
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TestDB>(opt => opt.UseInMemoryDatabase("ToDoList"));//與ver5不一樣前面多加builder Startup.cs與program.cs已整合一起
//新增上行才能在Controllers加入Scaffold項目
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddCors(options => {
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        }
        );
});//接受跨域
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();//接受跨域
app.UseAuthorization();

app.MapControllers();

app.Run();
