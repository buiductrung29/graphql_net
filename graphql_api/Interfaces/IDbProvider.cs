using SqlKata.Execution;

namespace graphql_api.Interfaces
{
    public interface IDbProvider
    {
        public QueryFactory Database();
    }
}
