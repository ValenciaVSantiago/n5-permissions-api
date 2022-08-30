namespace N5.Permissions.UserCases
{
    internal class ModifyInteractor : IModifyInteractor
    {
        private readonly IPermissionsRepository RepositoryService;
        private readonly IElasticSearchService ElasticClient;

        public ModifyInteractor(IPermissionsRepository repositoryService,
            IElasticSearchService elasticClient)
        {
            RepositoryService = repositoryService;
            ElasticClient = elasticClient;
        }

        public async ValueTask Handle(ModifyPermissionDTO permissionDTO)
        {
            var baseObj = RepositoryService.GetPermissionsById(permissionDTO.Id).Result;
            var permission = new Permission()
            {
                Id = permissionDTO.Id,
                EmployeeForename = String.IsNullOrEmpty(permissionDTO.EmployeeForename) ? baseObj.EmployeeForename : permissionDTO.EmployeeForename,
                EmployeeSurname = String.IsNullOrEmpty(permissionDTO.EmployeeSurname) ? baseObj.EmployeeSurname : permissionDTO.EmployeeSurname,
                PermissionTypeId = String.IsNullOrEmpty(permissionDTO.PermissionTypeId.ToString()) ? baseObj.PermissionTypeId : permissionDTO.PermissionTypeId,
                PermissionDate = DateTime.Now
            };

            await RepositoryService.ModifyPermissions(permission);
            await ElasticClient.Request(permission);
        }
    }
}
