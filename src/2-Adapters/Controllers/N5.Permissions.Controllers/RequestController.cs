namespace N5.Permissions.Controllers
{
    public class RequestController : IRequestController
    {
        private readonly IRequestInteractor Interactor;

        public RequestController(IRequestInteractor interactor)
        {
            Interactor = interactor;
        }

        public async ValueTask Request(RequestPermissionDTO request)
        {
            await Interactor.Handle(request);
        }
    }
}
