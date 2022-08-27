namespace N5.Permissions.Controllers
{
    public class RetriveController : IRetriveController
    {
        private readonly IRetriveInteractor Interactor;
        private readonly IRetrivePresenter Presenter;

        public RetriveController(IRetriveInteractor interactor,
            IRetrivePresenter presenter)
        {
            Interactor = interactor;
            Presenter = presenter;
        }

        public async ValueTask<PermissionDTO> Retrive(int retrive)
        {
            await Interactor.Handle();
            return Presenter.PermissionInfo;
        }
    }
}
