using graphql_api.Interfaces;
using graphql_api.Model;
using SqlKata.Execution;

namespace graphql_api.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly QueryFactory _queryFactory;
        public CategoryRepository(QueryFactory queryFactory)
        {
            _queryFactory = queryFactory;
        }
        public Category? GetById(int id)
        {
            return _queryFactory.Query("Categories").Where("Id", id).Get<Category>().FirstOrDefault();
        }

        public IEnumerable<Category> GetAll()
        {
            return _queryFactory.Query("Categories").Get<Category>();
        }
    }
}
