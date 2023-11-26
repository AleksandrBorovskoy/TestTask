namespace TestTaskAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required DateOnly BirthDate { get; set; }
    }
}
