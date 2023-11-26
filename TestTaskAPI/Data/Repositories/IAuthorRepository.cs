using TestTaskAPI.Dtos;
using TestTaskAPI.Models;

namespace TestTaskAPI.Data.Repositories
{
    public interface IAuthorRepository
    {
        Author Create(Author author);
        IList<Author> GetAll();

        void Update(int id, AuthorDto dto);

        void DeleteById(int id);
    }
}
