namespace N5.Permissions.Controllers
{
    public class ModifyController : IModifyController
    {
        private readonly IModifyInteractor Interactor;

        public ModifyController(IModifyInteractor interactor)
        {
            Interactor = interactor;
        }

        public async ValueTask Modify(ModifyPermissionDTO modify)
        {
            await Interactor.Handle();
        }
    }
}
