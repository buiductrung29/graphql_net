using GraphQL.Server.Ui.Playground;
using graphql_api.Data.Repository;
using graphql_api.Graphql;
using graphql_api.Graphql.UpdateSchema;
using graphql_api.Interfaces;
using Microsoft.Extensions.FileProviders;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddScoped((e) =>
    {
        var connection = new SqlConnection(builder.Configuration["ConnectionStrings:AppDbContext"]);
        var compiler = new SqlServerCompiler();
        return new QueryFactory(connection, compiler);
    })
    .AddScoped<IUpdateRepository, UpdateRepository>();
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<UpdateType>();
builder.Services.AddCors();


var app = builder.Build();

app.UseCors(
    c => c
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin()
    );
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(System.IO.Path.Combine(builder.Environment.ContentRootPath, "Static")),
    RequestPath = "/static"
});
app.UseWebSockets();
app.UseRouting();
app.MapGraphQL("/graphql");
app.MapGraphQLPlayground("/playground", new PlaygroundOptions { });

app.Run();
