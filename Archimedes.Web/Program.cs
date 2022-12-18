using Archimedes.Business.Abstract;
using Archimedes.Business.Concrete;
using Archimedes.Data.Abstract;
using Archimedes.Data.Concrete.EfCore;
using Archimedes.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ArchimedeDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("con"));
});

builder.Services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
builder.Services.AddScoped<ICategoryService,CategoryManager>();
builder.Services.AddScoped<IProductRepository, EfCoreProductRepository>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IShopListRepository, EfCoreShopListRepository>();
builder.Services.AddScoped<IShopListService, ShopListManager>();
builder.Services.AddScoped<IShopListDetailRepository, EfCoreShopListDetailRepository>();
builder.Services.AddScoped<IShopListDetailService, ShopListDetailManager>();
builder.Services.AddScoped<IUserShopListRepository, EfCoreUserShopListRepository>();
builder.Services.AddScoped<IUserShopListService, UserShopListManager>();

builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    // Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 8;
    
    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = false;

    // User settings.
    options.User.AllowedUserNameCharacters =
           "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._";
    options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<ArchimedeDbContext>();

builder.Services.AddSession();
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

app.UseAuthentication();