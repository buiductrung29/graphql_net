using graphql_api.Interfaces;
using graphql_api.Model;
using SqlKata.Execution;

namespace graphql_api.Data.Repository
{
    public class UpdateRepository : IUpdateRepository
    {
        private readonly IDbProvider _dbProvider;
        public UpdateRepository(IDbProvider dbProvider)
        {
            _dbProvider = dbProvider;
        }
        public IEnumerable<Update> GetAll()
        {
            return _dbProvider.Database().Query("Updates").Get<Update>();
        }
    }
}
