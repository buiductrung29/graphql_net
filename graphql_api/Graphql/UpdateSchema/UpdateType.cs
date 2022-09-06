using graphql_api.Model;

namespace graphql_api.Graphql.UpdateSchema
{
    public class UpdateType : ObjectType<Update>
    {
        protected override void Configure(IObjectTypeDescriptor<Update> descriptor)
        {
            descriptor.Description("");
            descriptor.Field(u => u.Id).Ignore();
            descriptor.Field(u => u.PostedTime).Type<NonNullType<DateTimeType>>();
            descriptor.Field(u => u.Title).Type<NonEmptyStringType>();
            descriptor.Field(u => u.Detail).Type<NonEmptyStringType>();
        }
    }
}
