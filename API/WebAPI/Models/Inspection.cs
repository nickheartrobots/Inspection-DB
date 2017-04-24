using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Inspection
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DateTime TimeIn { get; set; }

        [Required]
        public DateTime TimeOut { get; set; }

        [Required]
        public Address Address { get; set; }

        [Required]
        public Inspector Inspector { get; set; }
    }
}