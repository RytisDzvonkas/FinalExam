using FinalEgzam.Database.Entities;
using FinalEgzam.RequestModels;

namespace FinalEgzam.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAll();
        List<User> GetUserById(int id);
        User AddNewUser(UserRequestModel user);
        User Update(int id, UserRequestModel user);
        User Delete(int id);
    }
}
