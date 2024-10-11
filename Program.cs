using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using dwdm_pws2_voluntarios.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<dwdm_pws2_voluntariosContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("dwdm_pws2_voluntariosContext") ?? throw new InvalidOperationException("Connection string 'dwdm_pws2_voluntariosContext' not found.")));

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
