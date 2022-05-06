using APIurok.Helper;
using AutoMapper;
using BLogics.Service;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Repo.IRepositories;
using Repo.Repositories;

var builder = WebApplication.CreateBuilder(args);


#region Db_Service


builder.Services.AddDbContext<AppDbContext>(options
        => options.UseNpgsql(
            builder.Configuration.GetConnectionString("DefaultConnection")
            )
        );

#endregion

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region BLogics

builder.Services.AddScoped<IMedicamentService, MedicamentService>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

#endregion

#region AutoMap

var mapConfiq = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MapperProfile());
});

builder.Services.AddSingleton(mapConfiq.CreateMapper());

#endregion

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
