using graphql_api.Interfaces;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Data.SqlClient;

namespace graphql_api.Data
{
    public class DbProvider : IDbProvider
    {
        private readonly IConfiguration _configuration;
        public DbProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public QueryFactory Database()
        {
            QueryFactory queryFactory;
            var connection = new SqlConnection(_configuration["ConnectionStrings:AppDbContext"]);
            var compiler = new SqlServerCompiler();
            queryFactory = new QueryFactory(connection, compiler);
            return queryFactory;
        }
    }
}
