using WebApplication2.Model;
using Microsoft.EntityFrameworkCore;
/// <summary>
///�w�˨��NuGet�M��
///Microsoft.EntityFrameworkCore.InMemory
///Microsoft.EntityFrameworkCore.Design
/// </summary>
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TestDB>(opt => opt.UseInMemoryDatabase("ToDoList"));//�Pver5���@�˫e���h�[builder Startup.cs�Pprogram.cs�w��X�@�_
//�s�W�W��~��bControllers�[�JScaffold����
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddCors(options => {
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        }
        );
});//�������
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
app.UseCors();//�������
app.UseAuthorization();

app.MapControllers();

app.Run();
