using AWebsite.Extensions;
using AWebsite.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<ISingletonService>(new OperationService());
builder.Services.AddScoped<IScopedService, OperationService>();
builder.Services.AddTransient<ITransientService, OperationService>();
var app = builder.Build();

app.MapGet("/now", (ISingletonService idSingleton,
    IScopedService idScoped1, IScopedService idScoped2,
    ITransientService idTransient1, ITransientService idTransient2) =>
{
    return $"Singleton instance: {idSingleton.Value}\r\n\r\n" +
        $"Scoped instance 1: {idScoped1.Value}\r\nScoped instance 2: {idScoped2.Value}\r\n\r\n" +
        $"Transient instance 1: {idTransient1.Value}\r\nTransient instance 2: {idTransient2.Value}";
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//Custom/Own Middleware with C# Extensions
app.UseTiming();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
