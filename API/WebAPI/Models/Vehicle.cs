using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Decal { get; set; }

        [Required]
        [StringLength(255)]
        public string Make { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [StringLength(255)]
        public string License { get; set; }
    }
}