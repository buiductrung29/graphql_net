using graphql_api.Model;

namespace graphql_api.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> GetById(Guid id); 
    }
}
