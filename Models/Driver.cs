using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntercityTransportation.Models
{
     public class Driver
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }  
        public string? MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhotoBase64 { get; set; }     
        public string? WorkExperience { get; set; }
        public DriverCategory DriverCategory { get; set; }
        public DriverClass DriverClass { get; set; }
    }
}
