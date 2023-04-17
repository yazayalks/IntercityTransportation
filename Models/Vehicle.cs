using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntercityTransportation.Models
{
    public class Vehicle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Model { get; set; }
        public Brand Brand { get; set; }
        public int SeatCount { get; set;}
        public int ReleaseYear { get; set; }
        public int RepairYear { get; set; }
        public int Mileage { get; set; }
        public string GovernmentNumber { get; set; }
        public string PhotoBase64 { get; set; }
    }
}
