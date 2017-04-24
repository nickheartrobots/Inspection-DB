using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Inspector
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string Number { get; set; }
    }
}