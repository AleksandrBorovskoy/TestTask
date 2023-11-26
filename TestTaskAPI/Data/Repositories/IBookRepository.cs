using TestTaskAPI.Dtos;
using TestTaskAPI.Models;

namespace TestTaskAPI.Data.Repositories
{
    public interface IBookRepository
    {
        Book Create(Book book);
        IList<Book> GetAll();

        void Update(int id, BookDto book);

        void DeleteById(int id);
    }
}
