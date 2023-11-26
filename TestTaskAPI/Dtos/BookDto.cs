namespace TestTaskAPI.Dtos
{
    public class BookDto
    {
        public required string Title { get; set; }
        public required DateOnly YearOfPublication { get; set; }
        public required string Genre { get; set; }
    }
}
