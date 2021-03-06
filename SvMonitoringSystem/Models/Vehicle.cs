﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SvMonitoringSystem.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string RegistrationNumber { get; set; }
        public string Mark { get; set; }
        public string ModelType { get; set; }
        public int YearIssue { get; set; }
        public string VehicleType { get; set; }

        public int? VehicleGroupId { get; set; }
        public VehicleGroup VehicleGroup { get; set; }
    }
}
