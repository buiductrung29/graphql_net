namespace graphql_api.Model
{
    public class Update
    {
        public Guid Id { get; set; }
        public DateTime PostedTime { get; set; }
        public String? Title { get; set; }
        public String? Detail { get; set; }
    }
}
