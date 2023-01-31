using libraryApp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseHttpLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

new dataHandler("E:/Google's Temp Drive/GUI/Projects/Project 3 - Web Client Side Rendering/Backend/JSON Datasources/");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
