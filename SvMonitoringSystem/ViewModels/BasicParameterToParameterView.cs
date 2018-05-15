using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SvMonitoringSystem.Models;

namespace SvMonitoringSystem.ViewModels
{
    public class BasicParameterToParameterView
    {
        public List<BasicParameter> BasicParameterViewModel { get; set; }
        public List<Parameter> ParameterViewModel { get; set; }
    }

    public class Parameter2
    {
        public int BasicParameterId;
        public int BasicParameterValue;
        public string SpnNameRu;
    }
}
