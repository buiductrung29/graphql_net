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
            descriptor.Field(u => u.Email).Type<EmailAddressType>();
            descriptor.Field(u => u.Name).Type<NonEmptyStringType>();
            descriptor.Field(u => u.NameNormalize).Type<NonEmptyStringType>();
            descriptor.Field(u => u.Address).Type<StringType>();
            descriptor.Field(u => u.Gender).Type<NonEmptyStringType>();
            descriptor.Field(u => u.NationalID).Type<NationalIDType>().ResolveWith<UserResolver>(ur => ur.GetNationalID(default, default));
        }
    }
}
