using graphql_api.Interfaces;
using graphql_api.Model;

namespace graphql_api.Graphql.UserSchema
{
    public class UserResolver
    {
        public async Task<NationalID> GetNationalID([Service] INationalIDRepository repo, [Parent] User parent)
        {
            return await repo.GetById(parent.Id);
        }
    }
}
