using CarService.ViewModels;
using CarService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CarService.Controllers
{
    public class VehicleController : ApiController
    {
        [Route("api/Vehicle")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            IList<VehicleViewModel> vehicleList = null;

            using (var ctx = new CarServiceEntities())
            {
                vehicleList = ctx.Vehicles.Select(x => new VehicleViewModel()
                {
                    ID = x.ID,
                    CustomerID = x.CustomerID,
                    CompanyID = x.CompanyID,
                    Plate = x.Plate,
                    Make = x.Make,
                    Model = x.Model,
                    Colour = x.Colour,
                    IsActive = x.IsActive

                }).ToList();

                if (vehicleList.Count == 0)
                {
                    return NotFound();
                }

                return Ok(vehicleList);
            }
        }

        [Route("api/Vehicle/GetByID")]
        [HttpGet]
        public IHttpActionResult GetByID(int id)
        {
            IList<VehicleViewModel> vehicleList = null;

            using (var ctx = new CarServiceEntities())
            {
                vehicleList = ctx.Vehicles.Where(x => x.ID == id).Select(x => new VehicleViewModel()
                {
                    ID = x.ID,
                    CustomerID = x.CustomerID,
                    CompanyID = x.CompanyID,
                    Plate = x.Plate,
                    Make = x.Make,
                    Model = x.Model,
                    Colour = x.Colour,
                    IsActive = x.IsActive

                }).ToList();
            }

            if (vehicleList.Count == 0)
            {
                return NotFound();
            }

            return Ok(vehicleList);
        }

        [Route("api/Vehicle/GetByCompanyID")]
        [HttpGet]
        public IHttpActionResult GetByCompanyID(int id)
        {
            IList<VehicleViewModel> vehicleList = null;

            using (var ctx = new CarServiceEntities())
            {
                vehicleList = ctx.Vehicles.Where(x => x.CompanyID == id).Select(x => new VehicleViewModel()
                {
                    ID = x.ID,
                    CustomerID = x.CustomerID,
                    CompanyID = x.CompanyID,
                    Plate = x.Plate,
                    Make = x.Make,
                    Model = x.Model,
                    Colour = x.Colour,
                    IsActive = x.IsActive

                }).ToList();
            }

            if (vehicleList.Count == 0)
            {
                return NotFound();
            }

            return Ok(vehicleList);
        }
        [Route("api/Vehicle/GetByCustomerID")]
        [HttpGet]
        public IHttpActionResult GetByCustomerID(int id)
        {
            IList<VehicleViewModel> vehicleList = null;

            using (var ctx = new CarServiceEntities())
            {
                vehicleList = ctx.Vehicles.Where(x => x.CustomerID == id).Select(x => new VehicleViewModel()
                {
                    ID = x.ID,
                    CustomerID = x.CustomerID,
                    CompanyID = x.CompanyID,
                    Plate = x.Plate,
                    Make = x.Make,
                    Model = x.Model,
                    Colour = x.Colour,
                    IsActive = x.IsActive

                }).ToList();
            }

            if (vehicleList.Count == 0)
            {
                return NotFound();
            }

            return Ok(vehicleList);
        }

        [Route("api/Vehicle/GetByPlate")]
        [HttpGet]
        public IHttpActionResult GetByPlate(string plate)
        {
            IList<VehicleViewModel> vehicleList = null;

            using (var ctx = new CarServiceEntities())
            {
                vehicleList = ctx.Vehicles.Where(x => x.Plate == plate).Select(x => new VehicleViewModel()
                {
                    ID = x.ID,
                    CustomerID = x.CustomerID,
                    CompanyID = x.CompanyID,
                    Plate = x.Plate,
                    Make = x.Make,
                    Model = x.Model,
                    Colour = x.Colour,
                    IsActive = x.IsActive

                }).ToList();
            }

            if (vehicleList.Count == 0)
            {
                return NotFound();
            }

            return Ok(vehicleList);
        }
        [Route("api/Vehicle/Insert")]
        [HttpPost]
        public IHttpActionResult InsertVehicle(VehicleViewModel newVehicle)
        {
            using (var ctx = new CarServiceEntities())
            {
                var vehicle = new Vehicle
                {
                    CustomerID = newVehicle.CustomerID,
                    CompanyID = newVehicle.CompanyID,
                    Plate = newVehicle.Plate,
                    Make = newVehicle.Make,
                    Model = newVehicle.Model,
                    Colour = newVehicle.Colour,
                    IsActive = 1
                };

                ctx.Vehicles.Add(vehicle);

                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Vehicle/Update")]
        [HttpPut]
        public IHttpActionResult UpdateVehicle(VehicleViewModel updateVehicle)
        {
            using (var ctx = new CarServiceEntities())
            {
                var vehicle = ctx.Vehicles.Where(x => x.ID == updateVehicle.ID).SingleOrDefault();

                if (vehicle == null)
                {
                    return NotFound();
                }
                vehicle.CustomerID = updateVehicle.CustomerID;
                vehicle.CompanyID = updateVehicle.CompanyID;
                vehicle.Plate = updateVehicle.Plate;
                vehicle.Make = updateVehicle.Make;
                vehicle.Model = updateVehicle.Model;
                vehicle.Colour = updateVehicle.Colour;
                vehicle.IsActive = updateVehicle.IsActive;
               
                ctx.SaveChanges();
            }

            return Ok();
        }

        //[Route("api/Vehicle/DeactivateByID")]
        //[HttpPut]
        //public IHttpActionResult DeactivateVehicleByID(int id)
        //{
        //    using (var ctx = new CarServiceEntities())
        //    {
        //        var vehicle = ctx.Vehicles.Where(x => x.ID == id).FirstOrDefault();

        //        if (vehicle == null)
        //        {
        //            return NotFound();
        //        }

        //        vehicle.IsActive = 0;

        //        ctx.SaveChanges();
        //    }

        //    return Ok();
        //}

        //[Route("api/Vehicle/ActivateByID")]
        //[HttpPut]
        //public IHttpActionResult ActivateVehicleByID(int id)
        //{
        //    using (var ctx = new CarServiceEntities())
        //    {
        //        var vehicle = ctx.Vehicles.Where(x => x.ID == id).FirstOrDefault();

        //        if (vehicle == null)
        //        {
        //            return NotFound();
        //        }

        //        vehicle.IsActive = 1;

        //        ctx.SaveChanges();
        //    }

        //    return Ok();
        //}

        //[Route("api/Vehicle/DeleteByID")]
        //[HttpDelete]
        //public IHttpActionResult DeleteVehicleById(int id)
        //{
        //    using (var ctx = new CarServiceEntities())
        //    {
        //        var vehicle = ctx.Vehicles.Where(x => x.ID == id).SingleOrDefault();

        //        if (vehicle == null)
        //        {
        //            return NotFound();
        //        }

        //        ctx.Vehicles.Remove(vehicle);

        //        ctx.SaveChanges();
        //    }

        //    return Ok();
        //}
    }
}