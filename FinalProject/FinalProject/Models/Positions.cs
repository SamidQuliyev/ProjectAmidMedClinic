using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmidmedClinic.Models
{
    public class Positions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Workers> Workers { get; set; }
        public List<Managment> Managment { get; set; }

    }
}
