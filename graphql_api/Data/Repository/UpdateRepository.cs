using graphql_api.Interfaces;
using graphql_api.Model;
using SqlKata.Execution;

namespace graphql_api.Data.Repository
{
    public class UpdateRepository : IUpdateRepository
    {
        private readonly QueryFactory _queryFactory;
        public UpdateRepository(QueryFactory queryFactory)
        {
            _queryFactory = queryFactory;
        }
        public IEnumerable<Update> All()
        {
            return _queryFactory.Query("Updates").Get<Update>();
        }
    }
}
