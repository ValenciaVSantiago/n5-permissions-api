namespace N5.Permissions.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPermissionsServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddUseCases()
            .AddControllers()
            .AddRepositories(configuration)
            .AddPresenters();

            return services;
        }
    }
}
