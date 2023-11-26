using TestTaskAPI.Dtos;
using TestTaskAPI.Models;

namespace TestTaskAPI.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly TestTaskDbContext _dbContext;

        public BookRepository(TestTaskDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Book Create(Book book)
        {
            _dbContext.Books.Add(book);
            book.Id = _dbContext.SaveChanges();

            return book;
        }

        public void DeleteById(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(b => b.Id == id);

            if (book != null)
            {
                _dbContext.Remove(book);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new NullReferenceException($"Book with id = {id} was not found");
            }
        }

        public IList<Book> GetAll()
        {
            var books = _dbContext.Books.ToList();
            return books;
        }

        public void Update(int id, BookDto dto)
        {
            var existingBook = _dbContext.Books.FirstOrDefault(b => b.Id == id);

            if (existingBook != null)
            {
                existingBook.Title = dto.Title;
                existingBook.YearOfPublication = dto.YearOfPublication;
                existingBook.Genre = dto.Genre;
                _dbContext.SaveChanges();
            }
            else
            {
                throw new NullReferenceException($"Book with id = {id} was not found");
            }
        }
    }
}
