namespace N5.Permissions.BusinessObjects.Interfaces.Ports
{
    public interface IRequestInteractor
    {
        ValueTask Handle(RequestPermissionDTO permission);
    }
}
