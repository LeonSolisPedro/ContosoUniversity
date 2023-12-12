using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ContosoUniversity.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// The AddDatabaseDeveloperPageExceptionFilter, allows to show different error pages.
// For migrations
builder.Services.AddRazorPages();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDbContext<SchoolContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
else
{
    //This thingy, allows to apply migrations on the fly. wowser!
    //As long as you run dotnet ef migrations add Initial
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
