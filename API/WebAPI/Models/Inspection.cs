using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Inspection
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Date { get; set; }

        [Required]
        [StringLength(255)]
        public string TimeIn { get; set; }

        [Required]
        [StringLength(255)]
        public string TimeOut { get; set; }

        [Required]
        public virtual Address Address { get; set; }

        [Required]
        public virtual Inspector Inspector { get; set; }

    }
}