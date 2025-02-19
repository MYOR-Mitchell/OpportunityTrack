using Microsoft.EntityFrameworkCore;
using OpportunityTrack.Models;

var builder = WebApplication.CreateBuilder(args);

// Register ApplicationDbContext with in-memory database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("OpportunityTrackAppDb"));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=JobApplications}/{action=Index}/{id?}");

app.Run();
