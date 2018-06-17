using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SvMonitoringSystem.Models
{
    public class SampleData
    {
        public static void Initialize(MonitoringContext context)
        {
            if (!context.BasicParameters.Any())
            {
                context.BasicParameters.AddRange(
                    new BasicParameter { SpnNameRu = "Время включения системы подачи газа", DataSource = "Отсутствует в J1339! (но есть Engine Total Hours of Gaseous Fuel Operation" },
                    new BasicParameter { Acronym = "GFC", SpnName = "Trip Gaseous", SpnNameRu = "Расход газа", DataSource = "CAN-шина, при наличии расходомера газа. Иначе-вычисляется через давление и проходное сечение форсунки впрыска газа" },
                    new BasicParameter { Acronym = "GP", SpnName = "Gas Pressure", SpnNameRu = "Давление газа", DataSource = "Внешний датчик давления" },
                    new BasicParameter { Acronym = "GFC", SpnName = "Trip Fuel", SpnNameRu = "Расход дизельного топлива", DataSource = "CAN шина, или датчик расхода" },
                    new BasicParameter { Acronym = "VD", SpnName = "Total Vehicle Distance", SpnNameRu = "Пробег автомобиля (пройденный путь)", DataSource = "CAN -шина" },
                    new BasicParameter { Acronym = "WBVS", SpnName = "Wheel-Based Vehicle Speed", SpnNameRu = "Скорость движения", DataSource = "CAN -шина" },
                    new BasicParameter { Acronym = "EEC1", SpnName = "Engine Speed", SpnNameRu = "Обороты двигателя", DataSource = "CAN -шина" },
                    new BasicParameter { Acronym = "ECT", SpnName = "Engine Coolant Temperature", SpnNameRu = "Температура двигателя", DataSource = "CAN -шина" },
                    new BasicParameter { Acronym = "TE", SpnName = "Exhaust Temperature", SpnNameRu = "Температура выхлопных газов", DataSource = "Дополнительный датчик на выхлопной  трубе" }

                );
                context.SaveChanges();
            }
            if (!context.Vehicles.Any())
            {
                context.Vehicles.AddRange(
                    new Vehicle { Mark = "BMW", ModelType = "E540", YearIssue = 1998, VehicleType = "ГР", VehicleGroupId = 1},
                    new Vehicle { Mark = "Mersedes", ModelType = "S230", YearIssue = 1996, VehicleType = "ГР", VehicleGroupId = 2 }

                );
                context.SaveChanges();
            }

            if (!context.Parameters.Any())
            {
                context.Parameters.AddRange(
                    new Parameter { VehicleId = 1, BasicParameterId = 2, BasicParameterValue = 112, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 54) },
                    new Parameter { VehicleId = 1, BasicParameterId = 3, BasicParameterValue = 113, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 54) },
                    new Parameter { VehicleId = 1, BasicParameterId = 4, BasicParameterValue = 114, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 54) },
                    new Parameter { VehicleId = 1, BasicParameterId = 5, BasicParameterValue = 115, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 54) },
                    new Parameter { VehicleId = 1, BasicParameterId = 6, BasicParameterValue = 116, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 54) },
                    new Parameter { VehicleId = 1, BasicParameterId = 7, BasicParameterValue = 117, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 54) },
                    new Parameter { VehicleId = 1, BasicParameterId = 8, BasicParameterValue = 118, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 54) },
                    new Parameter { VehicleId = 1, BasicParameterId = 9, BasicParameterValue = 119, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 54) },

                    new Parameter { VehicleId = 2, BasicParameterId = 2, BasicParameterValue = 122, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 56) },
                    new Parameter { VehicleId = 2, BasicParameterId = 3, BasicParameterValue = 123, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 56) },
                    new Parameter { VehicleId = 2, BasicParameterId = 4, BasicParameterValue = 124, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 56) },
                    new Parameter { VehicleId = 2, BasicParameterId = 5, BasicParameterValue = 125, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 56) },
                    new Parameter { VehicleId = 2, BasicParameterId = 6, BasicParameterValue = 126, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 56) },
                    new Parameter { VehicleId = 2, BasicParameterId = 7, BasicParameterValue = 127, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 56) },
                    new Parameter { VehicleId = 2, BasicParameterId = 8, BasicParameterValue = 128, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 56) },
                    new Parameter { VehicleId = 2, BasicParameterId = 9, BasicParameterValue = 129, BasicParameterTimeValue = new DateTime(2004, 10, 19, 10, 23, 56) }
                );
                context.SaveChanges();
            }

            if (!context.Roles.Any())
            {
                context.Roles.AddRange(
                    new Role { RoleName = "ADMIN" },
                    new Role { RoleName = "USER" }
                );
                context.SaveChanges();
            }

            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User { UserLogin = "Vasiliy", UserPassword = "11112222", UserName = "Василий", UserSurname = "Шайтан", UserPhone = "7911", RoleId = 1 },
                    new User { UserLogin = "Sasha", UserPassword = "22221111", UserName = "Саша", UserSurname = "Иванов", UserPhone = "7921", RoleId = 2 }
                );
                context.SaveChanges();
            }

            if (!context.Routes.Any())
            {
                context.Routes.AddRange(
                    new Route { VehicleId = 1, CoordinateLatitude = 60.001, CoordinateLongitude = 30.001, CoordinateTimeValue = new DateTime(2004, 10, 19, 10, 23, 51) },
                    new Route { VehicleId = 1, CoordinateLatitude = 60.002, CoordinateLongitude = 30.002, CoordinateTimeValue = new DateTime(2004, 10, 19, 10, 24, 51) },
                    new Route { VehicleId = 1, CoordinateLatitude = 60.003, CoordinateLongitude = 30.003, CoordinateTimeValue = new DateTime(2004, 10, 19, 10, 25, 51) },
                    new Route { VehicleId = 1, CoordinateLatitude = 60.004, CoordinateLongitude = 30.004, CoordinateTimeValue = new DateTime(2004, 10, 19, 10, 26, 51) },
                    new Route { VehicleId = 1, CoordinateLatitude = 60.005, CoordinateLongitude = 30.005, CoordinateTimeValue = new DateTime(2004, 10, 19, 10, 27, 51) },
                    new Route { VehicleId = 2, CoordinateLatitude = 60.101, CoordinateLongitude = 30.101, CoordinateTimeValue = new DateTime(2004, 10, 19, 10, 28, 51) }
                );
                context.SaveChanges();
            }
            if (!context.VehicleGroups.Any())
            {
                context.VehicleGroups.AddRange(
                    new VehicleGroup { VehicleGroupName = "Магнит" },
                    new VehicleGroup { VehicleGroupName = "Пятерочка" },
                    new VehicleGroup { VehicleGroupName = "Полушка" }
                );
                context.SaveChanges();
            }
            if (!context.VehicleInGroups.Any())
            {
                context.VehicleInGroups.AddRange(
                    new VehicleInGroup { VehicleGroupId = 2, VehicleId = 1 },
                    new VehicleInGroup { VehicleGroupId = 2, VehicleId = 2 },
                    new VehicleInGroup { VehicleGroupId = 3, VehicleId = 1 }
                );
                context.SaveChanges();
            }
            //if (!context.ExtendedParameters.Any())
            //{
            //    context.ExtendedParameters.AddRange(
            //        new ExtendedParameter { UserLogin = "Vasiliy", UserPassword = "11112222", UserName = "Василий", UserSurname = "Шайтан", UserPhone = "7911", RoleId = 1 },
            //    );
            //    context.SaveChanges();
            //}

        }
    }
}
