using BusinessLogicLayer;
using Core.Cache.Microsoft;
using Core.Cache.Redis;
using DataAccessLayer;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using StackExchange.Redis;
using System.Globalization;
using UI.Extensions.ServiceRegistration;
using UI.Middlewares;
using Utility.Security.Jwt;
using Hangfire;
using Hangfire.PostgreSql;
using UI.Extensions;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;
// Add services to the container.

builder.Services.AddHttpContextAccessor();
builder.Services.AddDataAccessLayerServiceRegistration(configuration);
builder.Services.AddBusinessLogicLayerServices();

builder.Services.AddHangfire(config =>
{
    config.UsePostgreSqlStorage(options =>
        options.UseNpgsqlConnection(
            configuration.GetConnectionString("SqlCon")));
});

builder.Services.AddHangfireServer();


builder.Services.AddSingleton<ITokenHelper, JwtHelper>();
builder.Services.AddMemoryCache();
builder.Services.AddAuthServices(configuration);

//var multiplexer = ConnectionMultiplexer.Connect(configuration["RedisSettings:ConnectionString"]);
//builder.Services.AddSingleton<IConnectionMultiplexer>(multiplexer);
//builder.Services.AddSingleton<IRedisCacheManager, RedisCacheManager>();
builder.Services.AddSingleton<IMemoryService, MemoryCacheService>();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder => builder.SetIsOriginAllowed((host) => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials());
});


builder.Services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                         .AddDataAnnotationsLocalization();
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
    {
        new CultureInfo("en-US"),
        new CultureInfo("tr"),
    };
    options.DefaultRequestCulture = new RequestCulture(culture: "tr", uiCulture: "tr");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});


builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors(x => x.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.UseAuthentication();
app.UseAuthorization();

app.UseHangfireDashboard("/hangfire");

app.UseMiddleware<CustomExceptionMiddleware>();

app.UseResponseCaching();

app.MapRazorPages();

app.MapControllerRoute(name: "default", pattern: "{controller=Auth}/{action=Login}");
app.MapControllerRoute(name: "Home", pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(name: "Error", pattern: "Error", defaults: new { controller = "Home", action = "Error" });


#region User
app.MapControllerRoute(
    name: "KullaniciIslemleri",
    pattern: "/kullanici_islemleri",
    defaults: new { controller = "User", action = "KullaniciIslemleri" }
);
app.MapControllerRoute(
    name: "UserDetail",
    pattern: "/kullanici_detay/{id}",
    defaults: new { controller = "User", action = "Detail" }
);

app.MapControllerRoute(
    name: "MotivasyonKartIslemleri",
    pattern: "/motivasyon_kartlari",
    defaults: new { controller = "MotivasyonKart", action = "Index" }
);
app.MapControllerRoute(
    name: "SemptomIslemleri",
    pattern: "/semptomlar",
    defaults: new { controller = "Symptom", action = "Index" }
);

app.MapControllerRoute(
    name: "EgzersizDetaylarý",
    pattern: "/egzersiz_detaylari",
    defaults: new { controller = "Exercise", action = "Index" }
);
app.MapControllerRoute(
    name: "MasajDetaylarý",
    pattern: "/masaj_detaylari",
    defaults: new { controller = "Massage", action = "Index" }
);
app.MapControllerRoute(
    name: "MesajIslemleri",
    pattern: "/iletisim",
    defaults: new { controller = "Contact", action = "Index" }
);
app.MapControllerRoute(
    name: "BildirimIslemleri",
    pattern: "/bildirimler",
    defaults: new { controller = "Notification", action = "Index" }
);
#endregion
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.UseDeveloperExceptionPage();


RecurringJob.AddOrUpdate<NotificationJob>(
    "general-reminder",
    job => job.SendGeneralReminder(),
    "0 20 * * *"
);

app.Run();
