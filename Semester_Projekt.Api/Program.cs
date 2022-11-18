using StamData.Application.Ansat.AnsatCommands;
using StamData.Application.Ansat.AnsatCommands.AnsatImplementations;
using StamData.Application.Ansat.AnsatRepositories;
using StamData.Infrastructure.Ansat.AnsatRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Clean Architecture
builder.Services.AddScoped<ICreateAnsatCommand, CreateAnsatCommand>();
builder.Services.AddScoped<IAnsatRepository, AnsatRepository>();

// Database
// Add-Migration InitialMigration -Context ServerContext -Project SqlServerContext.Migrations
// Update-Database -Context ServerContext
//builder.Services.AddDbContext<ServerContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SemesterProjektDbConnection"), x => x.MigrationsAssembly("SqlServerContext.Migrations")));

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
