namespace Book_Management_Form.Models
{
    public class BookDTOs
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Authors { get; set; } = new List<string>();
    }
}
