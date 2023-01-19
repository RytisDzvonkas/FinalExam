using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalEgzam.Database.Entities
{
    public class Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Surname { get; set; }
        [Required]
        public double PersonsCode { get; set; }
        [Required]
        public double PhoneNumber { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Email { get; set; }
        [Required]
        public byte[] ProfilePicture { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
