namespace N5.Permissions.BusinessObjects.Interfaces.Tools
{
    public interface IElasticSearchService
    {
        ValueTask Request(Permission permission);
    }
}
