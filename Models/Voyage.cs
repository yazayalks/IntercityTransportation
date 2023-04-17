using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntercityTransportation.Models
{
    public class Voyage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Driver Driver { get; set; } 
        public Vehicle Vehicle { get; set; }   
        public Route Route { get; set; }
        public DateTime VoyageDate { get; set; }
        public double TotalRevenues { get; set; }
        public int TicketCount { get; set; }
    }
}
