using System.ComponentModel.DataAnnotations;


namespace Vrote_Diana.Models
{
    public class Buyer
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

        [RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "Introdu un numar de forma '0722123123'.")]
        public string? Phone { get; set; }

        public ICollection<Vanzare>? Vanzari { get; set; }

        public int? MemberID { get; set; }
        public Member? Member { get; set; }
    }
}

