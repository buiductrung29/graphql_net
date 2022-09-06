using graphql_api.Interfaces;
using graphql_api.Model;

namespace graphql_api.Graphql
{
    public partial class Query
    {
        public IEnumerable<Update> GetUpdates([Service] IUpdateRepository repo) => repo.All(); 
    }
}
