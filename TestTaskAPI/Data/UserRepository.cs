using TestTaskAPI.Models;

namespace TestTaskAPI.Data
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

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
