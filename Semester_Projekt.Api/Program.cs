using Microsoft.EntityFrameworkCore;
using SqlServerContext;
using StamData.Application.Ansat.AnsatCommands;
using StamData.Application.Ansat.AnsatCommands.AnsatImplementations;
using StamData.Application.Ansat.AnsatQueries;
using StamData.Application.Ansat.AnsatQueries.AnsatImplementations;
using StamData.Application.Ansat.AnsatRepositories;
using StamData.Application.Kompetencer.KompetenceCommands;
using StamData.Application.Kompetencer.KompetenceCommands.KompetenceImplementations;
using StamData.Application.Kompetencer.KompetenceQueries;
using StamData.Application.Kompetencer.KompetenceQueries.KompetenceImplementations;
using StamData.Application.Kompetencer.KompetenceRepositories;
using StamData.Infrastructure.Ansat.AnsatRepositories;
using StamData.Infrastructure.Kompetencer.KompetenceRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Clean Architecture
// Ansat
builder.Services.AddScoped<ICreateAnsatCommand, CreateAnsatCommand>();
builder.Services.AddScoped<IAnsatRepository, AnsatRepository>();
builder.Services.AddScoped<IAnsatGetAllQuery, AnsatGetAllQuery>();
builder.Services.AddScoped<IAnsatGetQuery, AnsatGetQuery>();
builder.Services.AddScoped<IEditAnsatCommand, EditAnsatCommand>();
// Kompetence
builder.Services.AddScoped<ICreateKompetenceCommand, CreateKompetenceCommand>();
builder.Services.AddScoped<IKompetenceRepository, KompetenceRepository>();
builder.Services.AddScoped<IKompetenceGetAllQuery, KompetenceGetAllQuery>();
builder.Services.AddScoped<IEditKompetenceCommand, EditKompetenceCommand>();
builder.Services.AddScoped<IKompetenceGetQuery, KompetenceGetQuery>();




// Database
// Add-Migration InitialMigration -Context ServerContext -Project SqlServerContext.Migrations
// Update-Database -Context ServerContext
builder.Services.AddDbContext<ServerContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SemesterProjektDbConnection"), x => x.MigrationsAssembly("SqlServerContext.Migrations")));

var app = builder.Build();

// Configure the HTTP request pipeline.https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-a-more-complex-data-model-for-an-asp-net-mvc-application
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
