namespace graphql_api.Model
{
    public enum Gender
    {
        MALE = 1,
        FEMALE = 0,
        UNPROVIDED = 2,
        UNDEFINED = -1
    }

    public class NationalID
    {
        public string IdNumber { get; set; }
        public string DateOfIssue { get; set; }
        public string PlaceOfIssue { get; set; }
    }

    public class User
    {
        public Guid Id { get; set; }
        public DateTime Dob { get; set; }
        public string DomainName { get; set; }
        public string DomainNameNormalize { get; set; }
        public string Name { get; set; }
        public string NameNormalize { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public NationalID NationalID { get; set; }

    }
}
