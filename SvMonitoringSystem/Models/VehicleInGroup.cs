using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SvMonitoringSystem.Models
{
    public class VehicleInGroup
    {
        public int VehicleInGroupId { get; set; }

        public int VehicleGroupId { get; set; }
        public VehicleGroup VehicleGroup { get; set; }

        public int VehicleId { get; set; }   
        public Vehicle Vehicle { get; set; }
    }
}
