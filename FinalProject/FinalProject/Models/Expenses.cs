using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmidmedClinic.Models
{
    public class Expenses
    {

        public int Id { get; set; }

        public string ByWho { get; set; }
        public int Quantity { get; set; }
        public string Reason { get; set; }
        public DateTime Date { get; set; }



    }
}
