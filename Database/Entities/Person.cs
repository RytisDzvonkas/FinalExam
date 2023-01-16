using System.ComponentModel.DataAnnotations.Schema;

namespace FinalEgzam.Database.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double PersonsCode { get; set; }
        public double PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte[] ProfilePicture { get; set; }
        public Residence Residence { get; set; }
        public int ResidenceId { get; set; }
    }
}
