using System.ComponentModel.DataAnnotations;

namespace Common.Models
{
    public class Vehicle
    {
        [Key]
        [Required]
        [StringLength(255)]
        public string Vin { get; set; }

        [Required]
        [StringLength(255)]
        public string DecalNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string Make { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [StringLength(255)]
        public string License { get; set; }

        [Required]
        [StringLength(2)]
        public string LicenseState { get; set; }

        [Required]
        public float Odometer { get; set; }

        [StringLength(255)]
        public string UnitNumber { get; set; }
    }
}