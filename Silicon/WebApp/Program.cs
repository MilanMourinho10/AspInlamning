var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();





var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Home}/{id?}");

app.Run();
