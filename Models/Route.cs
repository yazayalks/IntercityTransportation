using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntercityTransportation.Models
{
    public class Route
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public City StartingPoint { get; set; }
        public City EndingPoint { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime TravelTime { get; set; }
        public ICollection<BusStop> BusStops { get; set; }
    }
}
