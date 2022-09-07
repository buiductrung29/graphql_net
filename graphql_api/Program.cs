using GraphQL.Server.Ui.Playground;
using graphql_api.Data;
using graphql_api.Data.Repository;
using graphql_api.Graphql;
using graphql_api.Graphql.UpdateSchema;
using graphql_api.Graphql.UserSchema;
using graphql_api.Interfaces;
using graphql_api.Model;
using Microsoft.Extensions.FileProviders;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddScoped<IDbProvider, DbProvider>()
    .AddScoped<IUserRepository, UserRepository>()
    .AddScoped<INationalIDRepository, NationalIDRepository>()
    .AddScoped<ICategoryRepository, CategoryRepository>()
    .AddScoped<IUpdateRepository, UpdateRepository>();
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<UserType>()
    .AddType<StudentType>()
    .AddType<NationalIDType>()
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
