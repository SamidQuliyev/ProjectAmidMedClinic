using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmidmedClinic.Models
{
    public class Patients
    {

        public int Id { get; set; }
        public string PatientNumber { get; set; }

        public string Name { get; set; }
        public string Contact { get; set; }
        public string Reason { get; set; }
        public string Doctors { get; set; }
        public DateTime Date { get; set; }
     
        public bool IsDeactive { get; set; }

        [NotMapped]

        public IFormFile Photo { get; set; }
        public List<DoctorsPatients> DoctorsPatients { get; set; }

    }
}
