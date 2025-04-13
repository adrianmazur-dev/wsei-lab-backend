using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyRazorPagesMovie.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MyRazorPagesMovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyRazorPagesMovieContext") ?? throw new InvalidOperationException("Connection string 'MyRazorPagesMovieContext' not found.")));

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
