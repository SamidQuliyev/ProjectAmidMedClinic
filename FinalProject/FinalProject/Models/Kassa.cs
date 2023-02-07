using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmidmedClinic.Models
{
    public class Kassa
    {
        public int Id { get; set; }
        public int Balance { get; set; }
        public int LastModifiedMoney { get; set; }
        public int LastModified { get; set; }
        public DateTime LastModifiedTime { get; set; }

    }
}
