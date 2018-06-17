using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SvMonitoringSystem.Models
{
    public class MonitoringContext : DbContext
    {
        public DbSet<BasicParameter> BasicParameters { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VehicleGroup> VehicleGroups { get; set; }
        public DbSet<VehicleInGroup> VehicleInGroups { get; set; }
        //public DbSet<ExtendedParameter> ExtendedParameters { get; set; }

        public MonitoringContext(DbContextOptions<MonitoringContext> options) : base(options)
        {

        }
    }
}
