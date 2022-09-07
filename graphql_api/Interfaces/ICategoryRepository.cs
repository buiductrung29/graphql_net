using graphql_api.Model;

namespace graphql_api.Interfaces
{
    public interface ICategoryRepository
    {
        public Category? GetById(int id);
        public IEnumerable<Category> GetAll();
    }
}
