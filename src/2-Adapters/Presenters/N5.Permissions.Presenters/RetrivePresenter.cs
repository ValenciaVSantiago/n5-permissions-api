namespace N5.Permissions.Presenters
{
    public class RetrivePresenter : IRetrivePresenter
    {
        public PermissionDTO PermissionInfo { get; private set; }

        public ValueTask Handle(Permission permission)
        {
            PermissionInfo = new PermissionDTO
            {
                Id = permission.Id,
                EmployeeForename = permission.EmployeeForename,
                EmployeeSurname = permission.EmployeeSurname,
                PermissionTypeId = permission.PermissionTypeId,
                PermissionDate = permission.PermissionDate
            };

            return ValueTask.CompletedTask;
        }
    }
}
