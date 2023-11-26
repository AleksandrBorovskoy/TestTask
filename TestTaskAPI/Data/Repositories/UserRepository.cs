using TestTaskAPI.Models;

namespace TestTaskAPI.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TestTaskDbContext _dbContext;
        public UserRepository(TestTaskDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User Create(User user)
        {
            _dbContext.Users.Add(user);
            user.Id = _dbContext.SaveChanges();

            return user;
        }

        public User GetByUsername(string username)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Username == username);
        }

        public User GetById(int id)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id == id);
        }
    }
}
