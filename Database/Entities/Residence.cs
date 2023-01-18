using System.ComponentModel.DataAnnotations;

namespace FinalEgzam.Database.Entities
{
    public class Residence
    {
        public int Id { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int HouseNumber { get; set; }
        public int FlatNumber { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
