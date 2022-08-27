namespace N5.Permissions.Controllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddControllers(this IServiceCollection services)
        {
            services.AddScoped<IModifyController, ModifyController>();
            services.AddScoped<IRequestController, RequestController>();
            services.AddScoped<IRetriveController, RetriveController>();
            return services;
        }
    }
}
