using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmidmedClinic.Models
{
    public class Vacancies
    {
        public int Id { get; set; }

        public string Name  { get; set; }
        public string VacantPosition{ get; set; }

        public string Requirements { get; set; }
        public string Offers { get; set; }

        public bool IsDeactive { get; set; }
    }
}
