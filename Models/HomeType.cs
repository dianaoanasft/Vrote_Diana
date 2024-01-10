using System.ComponentModel.DataAnnotations;

namespace Vrote_Diana.Models
{
    public class HomeType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Display(Name = "Assigned")]
        public bool Assigned { get; set; }
    }
}
