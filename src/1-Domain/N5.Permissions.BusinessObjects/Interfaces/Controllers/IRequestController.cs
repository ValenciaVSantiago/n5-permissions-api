namespace N5.Permissions.BusinessObjects.Interfaces.Controllers
{
    public interface IRequestController
    {
        ValueTask Request(RequestPermissionDTO request);
    }
}
