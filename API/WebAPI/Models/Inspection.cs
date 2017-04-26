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
        public virtual Address Address { get; set; }

        [Required]
        public virtual Inspector Inspector { get; set; }

    }
}