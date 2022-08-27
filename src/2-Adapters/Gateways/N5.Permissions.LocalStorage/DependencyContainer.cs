namespace N5.Permissions.LocalStorage
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.AddDbContext<PermissionContext>(options =>
                options.UseSqlServer(configuration["N5:SqlConnetionString"]));

            services.AddScoped<IPermissionsRepository, PermissionsRepository>();
            return services;
        }
    }
}
