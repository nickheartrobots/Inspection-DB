using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        [Required]
        [ForeignKey("Inspector")]
        public int InspectorId { get; set; }
        public Inspector Inspector { get; set; }

    }
}