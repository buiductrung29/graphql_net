using graphql_api.Interfaces;
using graphql_api.Model;
using SqlKata.Execution;

namespace graphql_api.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbProvider _dbProvider;
        public UserRepository(IDbProvider dbProvider)
        {
            _dbProvider = dbProvider;
        }
        public async Task<User> GetById(Guid id)
        {
            return (await _dbProvider.Database().Query("Users").Where("Id", id).GetAsync<User>()).FirstOrDefault();
        }
    }
}
