using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SvMonitoringSystem.Models
{
    public class VehicleGroup
    {
        public int VehicleGroupId { get; set; }
        public string VehicleGroupName { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
