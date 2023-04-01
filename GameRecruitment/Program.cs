using Auth0.AspNetCore.Authentication;
using GameRecruitment.DataContext;
using GameRecruitment.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<GamingClubDataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
builder.Services.AddTransient<GamingClubDataContext, GamingClubDataContext >(); 
    builder.Services.AddTransient<DevInfosRepository,DevInfosRepository >();
    builder.Services.AddTransient<GameInfosRepository, GameInfosRepository >();
    builder.Services.AddTransient<TesterInfosRepository,TesterInfosRepository >();
builder.Services.AddTransient<CompanyInfosRepository,  CompanyInfosRepository >();

builder.Services.AddAuth0WebAppAuthentication(options =>
{
    options.Domain = builder.Configuration["Auth0:Domain"];
    options.ClientId = builder.Configuration["Auth0:ClientId"];
});

var app = builder.Build();

app.UseAuthentication();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
