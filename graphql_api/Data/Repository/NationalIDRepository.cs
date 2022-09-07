using graphql_api.Interfaces;
using graphql_api.Model;
using SqlKata.Execution;

namespace graphql_api.Data.Repository
{
    public class NationalIDRepository : INationalIDRepository
    {
        private readonly IDbProvider _dbProvider;
        public NationalIDRepository(IDbProvider dbProvider)
        {
            _dbProvider = dbProvider;
        }
        public async Task<NationalID> GetById(Guid id)
        {
            return (await _dbProvider.Database().Query("NationalIDs").Where("UserId", id).GetAsync<NationalID>()).FirstOrDefault();
        }
    }
}
