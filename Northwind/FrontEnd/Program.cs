using FrontEnd.Helpers.Implementaciones;
using FrontEnd.Helpers.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IShipperHelper, ShipperHelper>();
builder.Services.AddScoped<ICustomerHelper, CustomerHelper>();
builder.Services.AddScoped<IEmployeesHelper, EmployeesHelper>();
builder.Services.AddScoped<IOrderHelper, OrderHelper>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
