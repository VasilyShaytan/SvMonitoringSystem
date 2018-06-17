using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SvMonitoringSystem.Models
{
    public class ExtendedParameter
    {
        public int ExtendedParameterId { get; set; }
        public double TirePressure { get; set; }
        public double WearBrokePad { get; set; }
        public double LevelEngineOil { get; set; }
        public double PressureEngineOil { get; set; }
        public double CoolantLevel { get; set; }
        public double PneumaticSuspension { get; set; }
        public double WeightRoadTrain { get; set; }
    }
}
