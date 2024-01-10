using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vrote_Diana.Data;
using Vrote_Diana.Models;

namespace Vrote_Diana.Models
{
    public class Vanzare
    {
        public int ID { get; set; }
        public int? HomeID { get; set; }

        public Home? Home { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataVanzare { get; set; }

        [Range(1, 10000)]
        [DataType(DataType.Currency)]
        public int? PretVanzare { get; set; }

        public int? BuyerID { get; set; }
        public Buyer? Buyer { get; set; }
       
    }
}

