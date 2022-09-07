using graphql_api.Interfaces;
using graphql_api.Model;

namespace graphql_api.Graphql.UpdateSchema
{
    public class UpdateResolver
    {
        public String? GetCategoryName([Service] ICategoryRepository repo, [Parent] Update parent) => repo.GetById(parent.CategoryId)?.Name;
        public async Task<User?> GetUser([Service] IUserRepository repo, [Parent] Update parent) => await repo.GetById(parent.UploaderId);
    }
}
