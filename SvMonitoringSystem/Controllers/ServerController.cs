using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Query.Expressions;
using SQLitePCL;
using SvMonitoringSystem.Models;
using SvMonitoringSystem.ViewModels;
using System.Web.Helpers;


namespace SvMonitoringSystem.Controllers
{
    public class ServerController : Controller
    {
        private readonly MonitoringContext _context;

        public ServerController(MonitoringContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult VehicleGroup()
        {
            int selectedIndex = 1;
            SelectList vehicleGroups = new SelectList(_context.VehicleGroups, "VehicleGroupId", "VehicleGroupName", selectedIndex);
            ViewBag.VehicleGroups = vehicleGroups;
            SelectList vehicles = new SelectList(_context.Vehicles.Where(c => c.VehicleGroupId == selectedIndex), "VehicleId", "Mark");
            ViewBag.Vehicles = vehicles;
            return View();
        }
        public List<Vehicle> GetItems(int id)
        {
            //return PartialView(_context.Vehicles.Where(c => c.VehicleGroupId == id).ToList());
            return _context.Vehicles.Where(c => c.VehicleGroupId == id).ToList();
        }

        public IActionResult FlightReport()
        {
            int selectedIndex = 1;
            SelectList vehicleGroups = new SelectList(_context.VehicleGroups, "VehicleGroupId", "VehicleGroupName", selectedIndex);
            ViewBag.VehicleGroups = vehicleGroups;
            SelectList vehicles = new SelectList(_context.Vehicles.Where(c => c.VehicleGroupId == selectedIndex), "VehicleId", "Mark");
            ViewBag.Vehicles = vehicles;
            SelectList parameters = new SelectList(_context.Parameters.Where(c => c.VehicleId == selectedIndex), "BasicParameterId", "BasicParameterValue");
            ViewBag.Parameters = parameters;
            return View();
        }

        public IActionResult FuelReport()
        {
            int selectedIndex = 1;
            SelectList vehicleGroups = new SelectList(_context.VehicleGroups, "VehicleGroupId", "VehicleGroupName", selectedIndex);
            ViewBag.VehicleGroups = vehicleGroups;
            SelectList vehicles = new SelectList(_context.Vehicles.Where(c => c.VehicleGroupId == selectedIndex), "VehicleId", "Mark");
            ViewBag.Vehicles = vehicles;
            SelectList parameters = new SelectList(_context.Parameters.Where(c => c.VehicleId == selectedIndex), "BasicParameterId", "BasicParameterValue");
            ViewBag.Parameters = parameters;
            return View();
        }


        public IActionResult GetFlight(int id)
        {
            var list = new List<Parameter2>();


            var data = (from p in _context.Parameters
                join bp in _context.BasicParameters on p.BasicParameterId equals bp.BasicParameterId
                select new Parameter2() { BasicParameterId = id, BasicParameterValue = p.BasicParameterValue, SpnNameRu = bp.SpnNameRu}).ToList();


            //list = _context.BasicParameters.Select(p => BasicParameterId = )
            //var data = new BasicParameterToParameterView();
            //data.BasicParameterViewModel = _context.BasicParameters.Select(p => new BasicParameter() { BasicParameterId = id }).ToList();
            //data.ParameterViewModel = _context.Parameters.Select(p => new Parameter() { BasicParameterId = id}).ToList();
            return PartialView(data);
            //return PartialView(_context.Parameters.Where(c => c.VehicleId == id).ToList());
        }

        public List<Parameter2> GetFuel(int id)
        {
            var list = new List<Parameter2>();
            var data = (from p in _context.Parameters
                        join bp in _context.BasicParameters on p.BasicParameterId equals bp.BasicParameterId
                        select new Parameter2() { BasicParameterId = id, BasicParameterValue = p.BasicParameterValue, SpnNameRu = bp.SpnNameRu }).ToList();

            return data;

        }

        public IActionResult RouteList()
        {
            int selectedIndex = 1;
            SelectList vehicleGroups = new SelectList(_context.VehicleGroups, "VehicleGroupId", "VehicleGroupName", selectedIndex);
            ViewBag.VehicleGroups = vehicleGroups;
            SelectList vehicles = new SelectList(_context.Vehicles.Where(c => c.VehicleGroupId == selectedIndex), "VehicleId", "Mark");
            ViewBag.Vehicles = vehicles;

            return View();
        }

        public List<Route> GetCoordinates(int id)
        {
            //ViewBag.Coordinate = _context.Routes.Where(c => c.VehicleId == id).ToList().Last();
            //return PartialView(_context.Routes.Where(c => c.VehicleId == id).ToList());
            return _context.Routes.Where(c => c.VehicleId == id).OrderByDescending(x => x.RouteId).ToList();
         
        }

        public IActionResult OverallRating()
        {
            //int selectedIndex = 1;
            //SelectList vehicleGroups = new SelectList(_context.VehicleGroups, "VehicleGroupId", "VehicleGroupName", selectedIndex);
            //ViewBag.VehicleGroups = vehicleGroups;
            //SelectList vehicles = new SelectList(_context.Vehicles.Where(c => c.VehicleGroupId == selectedIndex), "VehicleId", "Mark");
            //ViewBag.Vehicles = vehicles;

            return View();
        }

        public IActionResult AdvancedDiagnosticParameter()
        {
            int selectedIndex = 1;
            SelectList vehicleGroups = new SelectList(_context.VehicleGroups, "VehicleGroupId", "VehicleGroupName", selectedIndex);
            ViewBag.VehicleGroups = vehicleGroups;
            SelectList vehicles = new SelectList(_context.Vehicles.Where(c => c.VehicleGroupId == selectedIndex), "VehicleId", "Mark");
            ViewBag.Vehicles = vehicles;
            return View();
        }

        public IActionResult GeozoneReport()
        {
            //int selectedIndex = 1;
            //SelectList vehicleGroups = new SelectList(_context.VehicleGroups, "VehicleGroupId", "VehicleGroupName", selectedIndex);
            //ViewBag.VehicleGroups = vehicleGroups;
            //SelectList vehicles = new SelectList(_context.Vehicles.Where(c => c.VehicleGroupId == selectedIndex), "VehicleId", "Mark");
            //ViewBag.Vehicles = vehicles;

            return View();
        }

        public IActionResult PsychoConditionDriver()
        {
            return View();
        }
    }
}
