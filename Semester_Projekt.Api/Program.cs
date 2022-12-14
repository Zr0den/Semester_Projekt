using Application.Booking.BookingCommands;
using Application.Booking.BookingCommands.Implementations;
using Application.Booking.BookingQueries;
using Application.Booking.BookingQueries.Implementations;
using Application.Booking.BookingRepositories;
using Application.Opgave.OpgaveCommands;
using Application.Opgave.OpgaveCommands.OpgaveImplementations;
using Application.Opgave.OpgaveQueries;
using Application.Opgave.OpgaveQueries.OpgaveImplementations;
using Application.Opgave.OpgaveRepositories;
using Application.Projekt.ProjektCommands;
using Application.Projekt.ProjektCommands.ProjektImplementations;
using Application.Projekt.ProjektQueries;
using Application.Projekt.ProjektQueries.ProjektImplementations;
using Application.Projekt.ProjektRepositories;
using Application.StamData.Ansat.AnsatCommands;
using Application.StamData.Ansat.AnsatCommands.AnsatImplementations;
using Application.StamData.Ansat.AnsatQueries;
using Application.StamData.Ansat.AnsatQueries.AnsatImplementations;
using Application.StamData.Ansat.AnsatRepositories;
using Application.StamData.Kompetencer.KompetenceCommands;
using Application.StamData.Kompetencer.KompetenceCommands.KompetenceImplementations;
using Application.StamData.Kompetencer.KompetenceQueries;
using Application.StamData.Kompetencer.KompetenceQueries.KompetenceImplementations;
using Application.StamData.Kompetencer.KompetenceRepositories;
using Application.StamData.Kunde.KundeCommands;
using Application.StamData.Kunde.KundeCommands.Implementation;
using Application.StamData.Kunde.KundeQueries;
using Application.StamData.Kunde.KundeQueries.Implementation;
using Application.StamData.Kunde.KundeRepositories;
using Domain.Projekt.ProjektDomainServices;
using Domain.StamData.Ansat.AnsatDomainServices;
using Infrastructure.Booking.BookingRepositories;
using Infrastructure.Opgave.OpgaveRepositories;
using Infrastructure.Projekt.ProjektDomainServices;
using Infrastructure.Projekt.ProjektRepositories;
using Infrastructure.StamData.Ansat.AnsatDomainServices;
using Infrastructure.StamData.Ansat.AnsatRepositories;
using Infrastructure.StamData.Kompetencer.KompetenceRepositories;
using Infrastructure.StamData.Kunde.KundeRepositories;
using Microsoft.EntityFrameworkCore;
using SqlServerContext;

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
builder.Services.AddScoped<IAnsatDomainService, AnsatDomainService>();

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
builder.Services.AddScoped<IProjektDomainService, ProjektDomainService>();

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
// Booking
builder.Services.AddScoped<ICreateBookingCommand, CreateBookingCommand>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<IBookingGetAllQuery, BookingGetAllQuery>();
builder.Services.AddScoped<IEditBookingCommand, EditBookingCommand>();
builder.Services.AddScoped<IBookingGetQuery, BookingGetQuery>();




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
