using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Inspector
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string InspectorLastName { get; set; }

        [Required]
        [StringLength(255)]
        public string InspectorFirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string InspectorNumber { get; set; }
    }
}