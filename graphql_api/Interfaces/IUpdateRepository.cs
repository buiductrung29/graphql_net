using graphql_api.Model;

namespace graphql_api.Interfaces
{
    public interface IUpdateRepository
    {
        public IEnumerable<Update> GetAll();
    }
}
