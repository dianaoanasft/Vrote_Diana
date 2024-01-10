using System.ComponentModel.DataAnnotations;

namespace Vrote_Diana.Models
{
    public class Location
    {
        public int ID { get; set; }

        [Display(Name = "Location Name")]
        public string LocationName { get; set; }
        public ICollection<Home>? Homes { get; set; }

    }
}
