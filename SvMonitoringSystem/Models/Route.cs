using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SvMonitoringSystem.Models
{
    public class Route
    {
        public int RouteId { get; set; }
        public double CoordinateLatitude { get; set; }
        public double CoordinateLongitude { get; set; }
        public DateTime CoordinateTimeValue { get; set; }

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
