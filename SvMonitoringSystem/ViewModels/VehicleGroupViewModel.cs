using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using SvMonitoringSystem.Models;

namespace SvMonitoringSystem.ViewModels
{
    public class VehicleGroupViewModel
    {
        public string VehicleGroupName { get; set; }

        public SelectList VehicleGroupSelectList { get; set; }
        //public ICollection<VehicleGroup> Cities { get; set; }

    }
}
