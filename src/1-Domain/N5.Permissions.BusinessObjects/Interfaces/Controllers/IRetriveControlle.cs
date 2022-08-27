namespace N5.Permissions.BusinessObjects.Interfaces.Controllers
{
    public interface IRetriveController
    {
        ValueTask<PermissionDTO> Retrive(int retrive);
    }
}
