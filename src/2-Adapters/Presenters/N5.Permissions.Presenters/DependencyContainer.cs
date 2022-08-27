using Microsoft.Extensions.DependencyInjection;
using N5.Permissions.BusinessObjects.Interfaces.Ports;

namespace N5.Permissions.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<IRetrivePresenter, RetrivePresenter>();
            return services;
        }
    }
}
