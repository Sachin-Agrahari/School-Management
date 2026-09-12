using Microsoft.Extensions.DependencyInjection;
using SchoolManagementERP.DataAccess;
using SchoolManagementERP.Interface;
using SchoolManagementERP.SqlHelper;

namespace SchoolManagementERP.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationExtensionsService(
            this IServiceCollection services)
        {
            services.AddScoped<SqlHelpers>();
            services.AddScoped<IStudent, Student>();
            services.AddScoped<IMaster, MasterData>();

            return services;
        }
    }
}