using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TheLifeOrganize_Inator.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name: "Agenda",
    areaName: "agenda",
    pattern: "Agenda/{controller=AgendaHome}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name: "PwdManager",
    areaName: "pwdmanager",
    pattern: "PasswordManager/{controller=PasswordManagerHome}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name: "PersonalFinances",
    areaName: "personalfinances",
    pattern: "PersonalFinances/{controller=PersonalFinancesHome}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name: "ToDoLists",
    areaName: "todolists",
    pattern: "To-do/{controller=ToDoHome}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
