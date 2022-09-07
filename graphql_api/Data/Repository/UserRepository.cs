using graphql_api.Interfaces;
using graphql_api.Model;
using SqlKata.Execution;

namespace graphql_api.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly QueryFactory _queryFactory;
        public UserRepository(QueryFactory queryFactory)
        {
            _queryFactory = queryFactory;
        }
        public async Task<User?> GetById(Guid id)
        {
            return (await _queryFactory.Query("Users").Where("Id", id).GetAsync<User>()).FirstOrDefault();
        }
    }
}
