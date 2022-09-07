using graphql_api.Model;

namespace graphql_api.Graphql.UserSchema
{
    public class NationalIDType : ObjectType<NationalID>
    {
        protected override void Configure(IObjectTypeDescriptor<NationalID> descriptor)
        {
            descriptor.Description("");
            descriptor.Field(nid => nid.UserId).Ignore();
            descriptor.Field(nid => nid.IdNumber).Name("cardNumber").Type<IdType>();
            descriptor.Field(nid => nid.DateOfIssue).Type<DateType>();
            descriptor.Field(nid => nid.PlaceOfIssue).Type<NonEmptyStringType>();
        }
    }
}
