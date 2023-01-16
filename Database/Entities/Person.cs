using System.ComponentModel.DataAnnotations.Schema;

namespace FinalEgzam.Database.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PersonsCode { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public int ProfilePicture { get; set; }
        public Residence Residence { get; set; }
        public int ResidenceId { get; set; }
    }
}
