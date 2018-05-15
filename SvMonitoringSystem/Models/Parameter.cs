using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SvMonitoringSystem.Models
{
    public class Parameter
    {
        public int ParameterId { get; set; }
        public int BasicParameterValue { get; set; }
        public DateTime BasicParameterTimeValue { get; set; }

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        public int BasicParameterId { get; set; }
        public BasicParameter BasicParameter { get; set; }
        
    }
}
