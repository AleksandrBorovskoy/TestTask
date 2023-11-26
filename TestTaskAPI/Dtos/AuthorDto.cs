namespace TestTaskAPI.Dtos
{
    public class AuthorDto
    {
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required DateOnly BirthDate { get; set; }
    }
}
