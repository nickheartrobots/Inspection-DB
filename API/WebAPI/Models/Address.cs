using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string StreetAddress1 { get; set; }

        [StringLength(255)]
        public string StreetAddress2 { get; set; }

        [Required]
        [StringLength(255)]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        public string State { get; set; }

        [Required]
        [StringLength(10)]
        public string Zip { get; set; }
    }
}