using CarService.ViewModels;
using CarService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace CarService.Controllers
{
    public class ServiceController : ApiController
    {

        [Route("api/Service")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            IList<ServiceViewModel> serviceList = null;

            using (var ctx = new CarServiceEntities())
            {
                serviceList = ctx.Services.Select(x => new ServiceViewModel()
                {
                    ID = x.ID,
                    CompanyID = x.CompanyID,
                    Name = x.Name,
                    Price = x.Price,
                    IsActive = x.IsActive,


                }).ToList();

                if (serviceList.Count == 0)
                {
                    return NotFound();
                }

                return Ok(serviceList);
            }
        }

        [Route("api/Service/GetByID")]
        [HttpGet]
        public IHttpActionResult GetByID(int id)
        {
            IList<ServiceViewModel> serviceList = null;

            using (var ctx = new CarServiceEntities())
            {
                serviceList = ctx.Services.Where(x => x.ID == id).Select(x => new ServiceViewModel()
                {
                    ID = x.ID,
                    CompanyID = x.CompanyID,
                    Name = x.Name,
                    Price = x.Price,
                    IsActive = x.IsActive,

                }).ToList();
            }

            if (serviceList.Count == 0)
            {
                return NotFound();
            }

            return Ok(serviceList);
        }

        [Route("api/Service/Insert")]
        [HttpPost]
        public IHttpActionResult InsertService(ServiceViewModel newService)
        {
            using (var ctx = new CarServiceEntities())
            {
                var service = new Service
                {
                    CompanyID = newService.CompanyID,
                    Name = newService.Name,
                    Price = newService.Price,
                    IsActive = 1
                };



                ctx.Services.Add(service);

                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Service/Update")]
        [HttpPut]
        public IHttpActionResult UpdateService(ServiceViewModel updateService)
        {
            using (var ctx = new CarServiceEntities())
            {
                var service = ctx.Services.Where(x => x.ID == updateService.ID).SingleOrDefault();

                if (service == null)
                {
                    return NotFound();
                }
                service.CompanyID = updateService.CompanyID;
                service.Name = updateService.Name;
                service.Price = updateService.Price;
              
                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Service/DeactivateByID")]
        [HttpPut]
        public IHttpActionResult DeactivateServiceByID(int id)
        {
            using (var ctx = new CarServiceEntities())
            {
                var service = ctx.Services.Where(x => x.ID == id).FirstOrDefault();

                if (service == null)
                {
                    return NotFound();
                }

                service.IsActive = 0;

                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Service/ActivateByID")]
        [HttpPut]
        public IHttpActionResult ActivateServiceByID(int id)
        {
            using (var ctx = new CarServiceEntities())
            {
                var service = ctx.Services.Where(x => x.ID == id).FirstOrDefault();

                if (service == null)
                {
                    return NotFound();
                }

                service.IsActive = 1;

                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Service/DeleteByID")]
        [HttpDelete]
        public IHttpActionResult DeleteServiceById(int id)
        {
            using (var ctx = new CarServiceEntities())
            {
                var service = ctx.Services.Where(x => x.ID == id).SingleOrDefault();

                if (service == null)
                {
                    return NotFound();
                }

                ctx.Services.Remove(service);

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}