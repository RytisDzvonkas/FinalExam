using FinalEgzam.Database.Entities;
using FinalEgzam.Repositories;
using FinalEgzam.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalEgzam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpGet]
        public List<User> Get()
        {
            return _userRepository.GetAll();
        }

        [HttpGet("id")]
        public List<User> GetUserById([FromQuery] int id)
        {
            return _userRepository.GetUserById(id);
        }

        [HttpPost]
        public User Add([FromBody] UserRequestModel user)
        {
            return _userRepository.AddNewUser(user);
        }

        [HttpPut]
        public User Update([FromQuery] int id, [FromBody] UserRequestModel user)
        {
            return _userRepository.Update(id, user);
        }

        [HttpDelete]
        public User Delete([FromQuery] int id)
        {
            return _userRepository.Delete(id);
        }
    }
}
