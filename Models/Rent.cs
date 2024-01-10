using System.ComponentModel.DataAnnotations;

namespace Vrote_Diana.Models
{
    public class Rent
    {
        public int ID { get; set; }

        public int? PossibleBuyerID { get; set; }
        public PossibleBuyer? PossibleBuyer { get; set; }

        public int? HomeID { get; set; }
        public Home? Home { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
    }
}
