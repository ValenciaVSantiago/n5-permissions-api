namespace N5.Permissions.BusinessObjects.Interfaces.Ports
{
    public interface IModifyInteractor
    {
        ValueTask Handle(ModifyPermissionDTO permission);
    }
}
