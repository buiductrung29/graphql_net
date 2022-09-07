using graphql_api.Model;

namespace graphql_api.Graphql.UserSchema
{
    public class UserType : ObjectType<User>
    {
        protected override void Configure(IObjectTypeDescriptor<User> descriptor)
        {
            descriptor.Description("");
            descriptor.Field(u => u.Id).Ignore();
            descriptor.Field(u => u.Dob).Type<NonNullType<DateType>>();
            descriptor.Field(u => u.DomainName).Type<NonEmptyStringType>().Name("domain");
            descriptor.Field(u => u.DomainNameNormalize).Type<NonEmptyStringType>().Name("domainNormalize");
        }
    }
}
