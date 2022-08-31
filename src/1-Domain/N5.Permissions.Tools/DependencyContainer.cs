namespace N5.Permissions.Tools
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddElasticsearch(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddSingleton<IElasticSearchService, ElasticSearchService>();

            var url = configuration["elasticsearch:url"];
            var defaultIndex = configuration["elasticsearch:index"];

            var settings = new ConnectionSettings(new Uri(url))
                .EnableApiVersioningHeader()
                .DefaultIndex(defaultIndex)
                .DefaultMappingFor<Permission>(m => m
                    .PropertyName(p => p.Id, "id")
                    .PropertyName(p => p.EmployeeForename, "employeeForename")
                    .PropertyName(p => p.EmployeeSurname, "employeeSurname")
                    .PropertyName(p => p.PermissionTypeId, "permissionTypeId")
                    .PropertyName(p => p.PermissionDate, "permissionDate")
                );

            var client = new ElasticClient(settings);

            services.AddSingleton<IElasticClient>(client);           

            return services;
        }
    }
}
