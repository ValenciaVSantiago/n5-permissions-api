namespace N5.Permissions.BusinessObjects.Interfaces.Ports
{
    public interface IRetrivePresenter
    {
        PermissionDTO PermissionInfo { get; }
        ValueTask Handle(Permission permission);
    }
}
