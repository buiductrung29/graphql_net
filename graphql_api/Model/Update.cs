namespace graphql_api.Model
{
    public class Update
    {
        public Guid Id { get; set; }
        public DateTime PostedTime { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public int CategoryId { get; set; }
        public Guid UploaderId { get; set; }
    }
}
