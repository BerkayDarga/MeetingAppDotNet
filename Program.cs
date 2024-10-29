var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

// {controller=Home}/{action=Index}/id?
// app.MapDefaultControllerRoute(); yerine aşağıdaki de yazılabilir
app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
);
app.Run();