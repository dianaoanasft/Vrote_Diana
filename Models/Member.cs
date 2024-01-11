using System.ComponentModel.DataAnnotations;

namespace Vrote_Diana.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Display(Name = "Full Name")]
        public string? FullName
        {
            get { return $"{LastName}{FirstName}"; }
        }

        [StringLength(70)]
        public string? Adress { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public ICollection<Buyer>? Buyers { get; set; }
    }
}
