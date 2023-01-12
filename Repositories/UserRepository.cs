using FinalEgzam.Database.Entities;
using FinalEgzam.Database;
using FinalEgzam.RequestModels;

namespace FinalEgzam.Repositories
{

    public class UserRepository : IUserRepository
    {
        public readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public List<User> GetUserById(int id)
        {
            return _context.Users.Where(p => p.Id == id).ToList();
        }
        public User AddNewUser(UserRequestModel user)
        {
            var newUser = new User()
            {
                Username = user.Username,
                Password = user.Password,
                Role = user.Role
            };
            _context.Users.Add(newUser);
            _context.SaveChanges();

            return newUser;
        }

        public User Update(int id, UserRequestModel user)
        {
            var UserToUpdate = _context.Users.Single(x => x.Id == id);
            UserToUpdate.Username = user.Username;
            UserToUpdate.Password = user.Password;
            UserToUpdate.Role = user.Role;
            _context.SaveChanges();

            return UserToUpdate;
        }

        public User Delete(int id)
        {
            var userToDelete = _context.Users.Single(x => x.Id == id);
            _context.Users.Remove(userToDelete);
            _context.SaveChanges();
            return userToDelete;
        }
    }
}

