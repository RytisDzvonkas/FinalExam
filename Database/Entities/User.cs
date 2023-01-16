using System.ComponentModel.DataAnnotations.Schema;

namespace FinalEgzam.Database.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
