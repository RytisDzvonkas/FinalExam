using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalEgzam.Database.Entities
{
    public class Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DefaultValue("name")]
        public string Name { get; set; }
        [DefaultValue("surname")]
        public string Surname { get; set; }
        [DefaultValue(0)]
        public double PersonsCode { get; set; }
        [DefaultValue(0)]
        public double PhoneNumber { get; set; }
        [DefaultValue("email")]
        public string Email { get; set; }
        [DefaultValue("ProfilePicture")]
        public byte[] ProfilePicture { get; set; }
        
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
