namespace TestTaskAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required DateOnly YearOfPublication { get; set; }
        public required string Genre { get; set; }
    }
}
