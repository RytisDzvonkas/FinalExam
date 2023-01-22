using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalEgzam.Database.Entities
{
    public class Residence
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DefaultValue("city")]
        public string City { get; set; }
        [DefaultValue("street")]
        public string Street { get; set; }
        [DefaultValue(0)]
        public int HouseNumber { get; set; }
        [DefaultValue(0)]
        public int FlatNumber { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User User{ get; set; }
    }
}
