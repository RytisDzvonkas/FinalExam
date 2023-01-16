using System.ComponentModel.DataAnnotations.Schema;

namespace FinalEgzam.RequestModels
{
    public class UserRequestModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int PersonId { get; set; }
    }
}
