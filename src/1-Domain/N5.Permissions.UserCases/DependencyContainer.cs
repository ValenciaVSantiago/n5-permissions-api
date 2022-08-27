namespace N5.Permissions.UserCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IModifyInteractor, ModifyInteractor>();
            services.AddScoped<IRequestInteractor, RequestInteractor>();
            services.AddScoped<IRetriveInteractor, RetriveInteractor>();
            return services;
        }
    }
}
