using IntercityTransportation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntercityTransportation.Utilities
{
    public class ExportVoyage
    {
        public string Id { get; set; }
        public string Driver { get; set; }
        public string Vehicle { get; set; }
        public string StartingPoint { get; set; }  
        public string EndingPoint { get; set; }
        public string VoyageDate { get; set; }
        public string TotalRevenues { get; set; }
        public string TicketCount { get; set; }
    }
}
