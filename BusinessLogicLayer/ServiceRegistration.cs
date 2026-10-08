using BusinessLogicLayer.Abstracts;
using BusinessLogicLayer.Concretes;
using BusinessLogicLayer.Helpers.SmsHelper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddBusinessLogicLayerServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IAuthBL, AuthBL>();
            services.AddScoped<IRoleBL, RoleBL>();
            services.AddScoped<IModuleBL, ModuleBL>();
            services.AddScoped<IUserBL, UserBL>();
            services.AddScoped<IModuleRoleBL, ModuleRoleBL>();
            services.AddScoped<INotificationBL, NotificationBL>();
            services.AddScoped<ICozumlemeSoruUserBL, CozumlemeSoruUserBL>();
            services.AddScoped<ISoruUserBL, SoruUserBL>();
            services.AddScoped<ISoruBL, SoruBL>();
            services.AddScoped<IOnBilgilendirmeBL,OnBilgilendirmeBL>();
            services.AddScoped<IOneTimePasswordService, SmsService>();
            return services;
        }
    }
}
