using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Semester_Projekt.Data;
using Semester_Projekt.Infrastructure.Contract;
using Semester_Projekt.Infrastructure.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add-Migration MigrationTest -Context ApplicationDbContext -Project UserContext.Migrations
// Update-Database -Context ApplicationDbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString, x => x.MigrationsAssembly("UserContext.Migrations")));

//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//builder.Services.AddDbContext<ServerContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SemesterProjektDbConnection"), x => x.MigrationsAssembly("SqlServerContext.Migrations")));

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
    {
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 5;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequiredUniqueChars = 0;
        options.Password.RequireUppercase = false;
        options.SignIn.RequireConfirmedAccount = false;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddRazorPages();


builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Admin", policybuilder => policybuilder.RequireClaim("Admin"));
    options.AddPolicy("Sælger", policybuilder => policybuilder.RequireClaim("Sælger"));
    options.AddPolicy("Tekniker", policybuilder => policybuilder.RequireClaim("Tekniker"));
    options.AddPolicy("Konverter", policybuilder => policybuilder.RequireClaim("Konverter"));
    options.AddPolicy("Konsulent", policybuilder => policybuilder.RequireClaim("Konsulent"));
    options.AddPolicy("Kunde", policybuilder => policybuilder.RequireClaim("Kunde"));
});

builder.Services.AddHttpClient<IService, Service>(client =>
    client.BaseAddress = new Uri(builder.Configuration["BaseUrl"])
);

// Database
// Add-Migration InitialMigration -Context ApplicationDbContext
// Update-Database -Context ApplicationDbContext

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
