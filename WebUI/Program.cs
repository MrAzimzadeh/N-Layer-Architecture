using Business.Abstract;
using Business.Concrete;
using DataAcces.Abstract;
using DataAcces.Concrete.SQLServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Todo ============================== Sql Connection ============================================================

builder.Services.AddScoped<AppDbContext>(); // ! 
/*
    !InvalidOperationException: Unable to resolve service for type 'Business.Abstract.ICategoryServices' while attempting to activate 'WebUI.Areas.Admin.Controllers.CategoryController'.
    * bu errorun sebebi elaqe olmamasidi onu bu yolla hell edirik
*/

builder.Services.AddScoped<ICategoryServices, CategoryManager>();
builder.Services.AddScoped<ICategoryDAL , CategoryDAL>();
var app = builder.Build();

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

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
