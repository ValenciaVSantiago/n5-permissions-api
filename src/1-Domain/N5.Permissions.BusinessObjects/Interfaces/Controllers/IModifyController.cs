namespace N5.Permissions.BusinessObjects.Interfaces.Controllers
{
    public interface IModifyController
    {
        ValueTask Modify(ModifyPermissionDTO modify);
    }
}
