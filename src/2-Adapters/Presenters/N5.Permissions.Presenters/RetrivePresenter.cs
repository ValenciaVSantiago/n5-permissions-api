using N5.Permissions.BusinessObjects.DTOs;
using N5.Permissions.BusinessObjects.Interfaces.Ports;

namespace N5.Permissions.Presenters
{
    public class RetrivePresenter : IRetrivePresenter
    {
        public PermissionDTO PermissionInfo { get; private set; }

        public ValueTask Handle()
        {
            PermissionInfo = new PermissionDTO
            {

            };

            return ValueTask.CompletedTask;
        }
    }
}
