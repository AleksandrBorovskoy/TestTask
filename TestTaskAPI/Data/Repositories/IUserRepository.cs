using TestTaskAPI.Models;

namespace TestTaskAPI.Data.Repositories
{
    public interface IUserRepository
    {
        User Create(User user);
        User GetByUsername(string username);

        User GetById(int id);
    }
}
