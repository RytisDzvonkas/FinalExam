﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalEgzam.Database.Entities
{
    public class Person
    {
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
        public Residence Residence { get; set; }
        public int ResidenceId { get; set; }
        public User User { get; set; }
    }
}
