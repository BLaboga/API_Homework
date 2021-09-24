using Microsoft.Extensions.DependencyInjection;

namespace Api
{
    public static class StartupExtentions
    {
        public static IServiceCollection CongigureDependencyInjection(this IServiceCollection services)
        {
            //services.AddScoped<IObject, ActualObject>();

            return services;
        }
    }
}
