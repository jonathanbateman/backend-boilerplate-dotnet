using Microsoft.EntityFrameworkCore;
using LookupServiceAPI.Models;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<CreditDataContext>(opt => opt.UseInMemoryDatabase("CreditDataList"));
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

app.UseAuthorization();

app.MapControllers();

app.MapGet("/personal-details/{ssn}", async (CreditDataContext db) =>
    await db.CreditDataItems.FindAsync()
        is CreditDataItem creditDataItem
            ? Results.Ok(creditDataItem)
            : Results.NotFound());

app.MapGet("/assessed-income/{ssn}", async (CreditDataContext db) =>
    await db.CreditDataItems.FindAsync()
        is CreditDataItem creditDataItem
            ? Results.Ok(creditDataItem)
            : Results.NotFound());

app.MapGet("/debt/{ssn}", async (CreditDataContext db) =>
    await db.CreditDataItems.FindAsync()
        is CreditDataItem creditDataItem
            ? Results.Ok(creditDataItem)
            : Results.NotFound());

app.Run();
