namespace N5.Permissions.UserCases
{
    internal class RequestInteractor : IRequestInteractor
    {
        private readonly IPermissionsRepository RepositoryService;
        private readonly IElasticSearchService ElasticClient;

        public RequestInteractor(IPermissionsRepository repositoryService,
            IElasticSearchService elasticClient)
        {
            RepositoryService = repositoryService;
            ElasticClient = elasticClient;
        }

        public async ValueTask Handle(RequestPermissionDTO permissionDTO)
        {
            var permission = new Permission()
            {
                EmployeeForename = permissionDTO.EmployeeForename,
                EmployeeSurname = permissionDTO.EmployeeSurname,
                PermissionTypeId = permissionDTO.PermissionTypeId,
                PermissionDate = DateTime.Now
            };

            await RepositoryService.AddPermissions(permission);
            await ElasticClient.Request(permission);
        }
    }
}
