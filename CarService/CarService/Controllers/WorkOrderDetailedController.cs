using CarService.ViewModels;
using CarService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CarService.Controllers
{
    public class WorkOrderDetailedController : ApiController
    {

        [Route("api/WorkOrderDetailed")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            IList<WorkOrderDetailedModel> workOrderDetailedList = null;

            using (var ctx = new CarServiceEntities())
            {
                workOrderDetailedList = ctx.WorkOrderDetaileds.Select(x => new WorkOrderDetailedModel()
                {
                    ID = x.ID,
                    WorkOrderID = x.WorkOrderID,
                    ServiceID = x.ServiceID,
                    ServiceQuantity = x.ServiceQuantity,

                }).ToList();

                if (workOrderDetailedList.Count == 0)
                {
                    return NotFound();
                }

                return Ok(workOrderDetailedList);
            }
        }

        [Route("api/WorkOrderDetailed/GetByWorkOrderID")]
        [HttpGet]
        public IHttpActionResult GetByWorkOrderID(int id)                                      
        {
            IList<WorkOrderDetailedModel> workOrderDetailedList = null;
        
            using (var ctx = new CarServiceEntities())
            {
                workOrderDetailedList = ctx.WorkOrderDetaileds.Where(x => x.WorkOrderID == id).Select(x => new WorkOrderDetailedModel()
                {
                    ID = x.ID,
                    WorkOrderID = x.WorkOrderID,
                    ServiceID = x.ServiceID,
                    ServiceQuantity = x.ServiceQuantity,
        
                }).ToList();
            }
        
            if (workOrderDetailedList.Count == 0)
            {
                return NotFound();
            }
        
            return Ok(workOrderDetailedList);
        }

        [Route("api/WorkOrderDetailed/Insert")]
        [HttpPost]
        public IHttpActionResult InserWorkOrderDetailed(WorkOrderDetailedModel newWorkOrderDetailed)
        {
            using (var ctx = new CarServiceEntities())
            {
                var workOrderDetailed = new WorkOrderDetailed
                {
                    WorkOrderID = newWorkOrderDetailed.WorkOrderID,
                    ServiceID = newWorkOrderDetailed.ServiceID,
                    ServiceQuantity = newWorkOrderDetailed.ServiceQuantity
                };


                ctx.WorkOrderDetaileds.Add(workOrderDetailed);

                ctx.SaveChanges();
            }

            return Ok();
        }

        /* [HttpPut]
         public IHttpActionResult UpdateWorkOrderDetailed(WorkOrderDetailedModel updateWorkOrderDetailed)
         {
             using (var ctx = new CarServiceEntities())
             {
                 var workOrderDetailed = ctx.WorkOrderDetaileds.Where(x => x.ID == updateWorkOrderDetailed.ID).SingleOrDefault();

                 if (workOrderDetailed == null)
                 {
                     return NotFound();
                 }
                 workOrderDetailed.WorkOrderID = workOrderDetailed.WorkOrderID;
                 workOrderDetailed.ServiceID = workOrderDetailed.ServiceID;
                 workOrderDetailed.ServiceQuantity = workOrderDetailed.ServiceQuantity;


                 ctx.SaveChanges();
             }

             return Ok();
         }

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
         }*/
    }
}