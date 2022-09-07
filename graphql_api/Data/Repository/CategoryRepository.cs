using graphql_api.Interfaces;
using graphql_api.Model;
using SqlKata.Execution;

namespace graphql_api.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDbProvider _dbProvider;
        public CategoryRepository(IDbProvider dbProvider)
        {
            _dbProvider = dbProvider;
        }
        public Category GetById(int id)
        {
            return _dbProvider.Database().Query("Categories").Where("Id", id).Get<Category>().FirstOrDefault();
        }

        public IEnumerable<Category> GetAll()
        {
            return _dbProvider.Database().Query("Categories").Get<Category>();
        }
    }
}
