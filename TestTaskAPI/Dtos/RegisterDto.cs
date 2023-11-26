namespace TestTaskAPI.Dtos
{
    public class RegisterDto
    {
        public required string Username { get; set; }
        public required string Password { get; set; }

        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required DateOnly Birthdate { get; set; }
        public required string Address { get; set; }
    }
}
