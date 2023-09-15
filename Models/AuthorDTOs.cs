namespace Book_Management_Form
    {
    public class AuthorDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;

}
}