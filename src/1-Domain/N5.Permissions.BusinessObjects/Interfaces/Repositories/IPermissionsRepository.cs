namespace N5.Permissions.BusinessObjects.Interfaces.Storage
{
    public interface IPermissionsRepository
    {
        ValueTask<Permission> GetPermissionsById(int id);
        ValueTask AddPermissions(Permission permission);
        ValueTask ModifyPermissions(Permission permission);
    }
}
