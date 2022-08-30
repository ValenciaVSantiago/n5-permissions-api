namespace N5.Permissions.Tools
{
    public class ElasticSearchService : IElasticSearchService
    {
        private IElasticClient ElasticClient;

        public ElasticSearchService(IElasticClient elasticClient)
        {
            ElasticClient = elasticClient;
        }

        public async ValueTask Request(Permission permission)
        {
            try
            {
                await ElasticClient.IndexDocumentAsync(permission);
            }
            catch (Exception ex)
            {
                log(ex.Message);
                throw;
            }
        }

        private void log(string message)
        {
            using (var log = new LoggerConfiguration()
                    .WriteTo.Console()
                    .CreateLogger())
            {
                log.Warning(message);
            }
        }
    }
}
