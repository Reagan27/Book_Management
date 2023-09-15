using System.ComponentModel.DataAnnotations;

namespace Book_Management_Form.Models
{
    public class BookDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]

        public string Description { get; set; } = string.Empty;


        public List<AuthorDto> Authors { get; set; } 

    }

    internal class AuthorDTOs
    {
    }
}