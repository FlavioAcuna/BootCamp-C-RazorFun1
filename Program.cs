var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.MapControllerRoute(
    name: "defaul",
    pattern: "{controller=home}/{action=Index}/{id?}"
);
app.Run();
