using System.ComponentModel.DataAnnotations;

namespace Vrote_Diana.Models
{
    public class ContactInfo
    {
        public int ID { get; set; }

        [Required]
        public string ContactName { get; set; }

        [RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "Introdu un numar de forma '0722123123'.")]
        public string ContactPhone { get; set; }


        public string ContactEmail { get; set; }

        [StringLength(70)]

        public string ContactAdress { get; set; }
    }
}
