using Microsoft.EntityFrameworkCore;
using TenderTask.BusinessLogic.Profile;
using TenderTask.BusinessLogic.Services.Classes;
using TenderTask.BusinessLogic.Services.Interfaces;
using TenderTask.DataAccess;
using TenderTask.DataAccess.Context;
using TenderTask.DataAccess.Reporsitries.Classes;
using TenderTask.DataAccess.Reporsitries.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
    });

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ITenderService, TenderService>();
builder.Services.AddScoped<ITenderRepoistory, TenderRepoistory>();
builder.Services.AddScoped<ICategoryRepoistory, CategoryRepoistory>();

builder.Services.AddAutoMapper(typeof(MappingProfile));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(options => options.WithOrigins("http://127.0.0.1:5500").AllowAnyHeader().AllowAnyMethod());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
