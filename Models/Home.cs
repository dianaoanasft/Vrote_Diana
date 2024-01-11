using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Vrote_Diana.Models;

namespace Vrote_Diana.Models
{
    public class Home
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]

        public string? Name { get; set; }
        [Display(Name = "Availabe Date")]

        [DataType(DataType.Date)]
        public DateTime AvailabeDate { get; set; }
        public string? Type { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        [Range(1, 10000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public int? LocationID { get; set; }
        public Location? Location { get; set; }

        public int? VanzareID { get; set; }
        public Vanzare? Vanzare { get; set; }

        public int? MemberID { get; set; }
        public Member? Member { get; set; }


    }
}

