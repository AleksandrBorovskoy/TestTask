using TestTaskAPI.Models;

namespace TestTaskAPI.Data
{
    public interface IUserRepository
    {
        User Create(User user);
        User GetById(int id);
    }
}
