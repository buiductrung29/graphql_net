using graphql_api.Model;

namespace graphql_api.Interfaces
{
    public interface INationalIDRepository
    {
        public Task<NationalID> GetById(Guid id);
    }
}
