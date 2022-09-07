using graphql_api.Model;

namespace graphql_api.Graphql.UserSchema
{
    public class StudentType : ObjectType<User>
    {
        protected override void Configure(IObjectTypeDescriptor<User> descriptor)
        {
            descriptor.Description("");
            descriptor.Field(s => s.Id).Ignore();
            descriptor.Field(s => s.DomainNameNormalize).Name("domain").Type<NonEmptyStringType>();
            descriptor.Field(s => s.NameNormalize).Name("name").Type<NonEmptyStringType>();
            descriptor.Field(s => s.Dob).Type<DateType>();
            descriptor.Field(s => s.Email).Type<NonEmptyStringType>();
            descriptor.Field(s => s.Address).Type<StringType>();
        }
    }
}
