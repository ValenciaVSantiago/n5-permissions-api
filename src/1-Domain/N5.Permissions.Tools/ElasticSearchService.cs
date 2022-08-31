namespace N5.Permissions.Tools
{
    public class ElasticSearchService : IElasticSearchService
    {
        private IElasticClient ElasticClient;
        private IConfiguration Configuration;

        public ElasticSearchService(IElasticClient elasticClient, 
            IConfiguration configuration)
        {
            ElasticClient = elasticClient;
            Configuration = configuration;
        }

        public async ValueTask Request(Permission permission)
        {
            try
            {
                var defaultIndex = Configuration["elasticsearch:index"];
                var indexExists = await ElasticClient.Indices.ExistsAsync(defaultIndex);
                if (!indexExists.Exists)
                {
                    var response = await ElasticClient.Indices.CreateAsync(defaultIndex,
                       index => index.Map<Permission>(
                           x => x.AutoMap()
                       ));
                }

                var searchResponse = await ElasticClient.IndexDocumentAsync(permission);
                if (!searchResponse.IsValid)
                {
                    // Handle errors
                    var debugInfo = searchResponse.DebugInformation;
                    var error = searchResponse.ServerError.Error;
                }
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
