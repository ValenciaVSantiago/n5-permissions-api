namespace N5.Permissions.UserCases
{
    internal class RetriveInteractor : IRetriveInteractor
    {
        private readonly IRetrivePresenter Presenter;
        private readonly IPermissionsRepository RepositoryService;
        private readonly IElasticSearchService ElasticClient;

        public RetriveInteractor(IRetrivePresenter presenter,
            IPermissionsRepository repositoryService,
            IElasticSearchService elasticClient)
        {
            Presenter = presenter;
            RepositoryService = repositoryService;
            ElasticClient = elasticClient;
        }

        public async ValueTask Handle(int id)
        {
            var permission = RepositoryService.GetPermissionsById(id).Result;

            await Presenter.Handle(permission);
            await ElasticClient.Request(permission);
        }
    }
}
