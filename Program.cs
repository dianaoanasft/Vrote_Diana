using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Vrote_Diana.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Vrote_DianaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Vrote_DianaContext") ?? throw new InvalidOperationException("Connection string 'Vrote_DianaContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
