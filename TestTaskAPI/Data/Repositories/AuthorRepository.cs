using TestTaskAPI.Dtos;
using TestTaskAPI.Models;

namespace TestTaskAPI.Data.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly TestTaskDbContext _dbContext;

        public AuthorRepository(TestTaskDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Author Create(Author author)
        {
            _dbContext.Authors.Add(author);
            author.Id = _dbContext.SaveChanges();

            return author;
        }

        public void DeleteById(int id)
        {
            var author = _dbContext.Authors.FirstOrDefault(a => a.Id == id);

            if (author != null)
            {
                _dbContext.Remove(author);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new NullReferenceException($"Author with id = {id} was not found");
            }
        }

        public IList<Author> GetAll()
        {
            var authors = _dbContext.Authors.ToList();
            return authors;
        }

        public void Update(int id, AuthorDto dto)
        {
            var existingAuthor = _dbContext.Authors.FirstOrDefault(a => a.Id == id);

            if (existingAuthor != null)
            {
                existingAuthor.Name = dto.Name;
                existingAuthor.Surname = dto.Surname;
                existingAuthor.BirthDate = dto.BirthDate;
                _dbContext.SaveChanges();
            }
            else
            {
                throw new NullReferenceException($"Author with id = {id} was not found");
            }
        }
    }
}
