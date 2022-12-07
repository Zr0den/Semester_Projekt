using Microsoft.EntityFrameworkCore;
using Opgave.Application.OpgaveCommands;
using Opgave.Application.OpgaveCommands.OpgaveImplementations;
using Opgave.Application.OpgaveQueries;
using Opgave.Application.OpgaveQueries.OpgaveImplementations;
using Opgave.Application.OpgaveRepositories;
using Opgave.Infrastructure.OpgaveRepositories;
using Projekt.Application.ProjektCommands;
using Projekt.Application.ProjektCommands.ProjektImplementations;
using Projekt.Application.ProjektQueries;
using Projekt.Application.ProjektQueries.ProjektImplementations;
using Projekt.Application.ProjektRepositories;
using Projekt.Infrastructure.ProjektRepositories;
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
using StamData.Application.Kunde.KundeCommands;
using StamData.Application.Kunde.KundeCommands.Implementation;
using StamData.Application.Kunde.KundeQueries;
using StamData.Application.Kunde.KundeQueries.Implementation;
using StamData.Application.Kunde.KundeRepositories;
using StamData.Infrastructure.Ansat.AnsatRepositories;
using StamData.Infrastructure.Kompetencer.KompetenceRepositories;
using StamData.Infrastructure.Kunde.KundeRepositories;

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
// Projekt
builder.Services.AddScoped<ICreateProjektCommand, CreateProjektCommand>();
builder.Services.AddScoped<IProjektRepository, ProjektRepository>();
builder.Services.AddScoped<IProjektGetAllQuery, ProjektGetAllQuery>();
builder.Services.AddScoped<IEditProjektCommand, EditProjektCommand>();
builder.Services.AddScoped<IProjektGetQuery, ProjektGetQuery>();
// Kunde
builder.Services.AddScoped<ICreateKundeCommand, CreateKundeCommand>();
builder.Services.AddScoped<IKundeRepository, KundeRepository>();
builder.Services.AddScoped<IKundeGetAllQuery, KundeGetAllQuery>();
builder.Services.AddScoped<IEditKundeCommand, EditKundeCommand>();
builder.Services.AddScoped<IKundeGetQuery, KundeGetQuery>();
// Opgave
builder.Services.AddScoped<ICreateOpgaveCommand, CreateOpgaveCommand>();
builder.Services.AddScoped<IOpgaveRepository, OpgaveRepository>();
builder.Services.AddScoped<IOpgaveGetAllQuery, OpgaveGetAllQuery>();
builder.Services.AddScoped<IEditOpgaveCommand, EditOpgaveCommand>();
builder.Services.AddScoped<IOpgaveGetQuery, OpgaveGetQuery>();




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
