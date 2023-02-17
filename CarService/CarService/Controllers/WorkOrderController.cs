using CarService.ViewModels;
using CarService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CarService.Controllers
{
    public class WorkOrderController : ApiController
    {
        [Route("api/WorkOrder")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            IList<WorkOrderViewModel> workOrder = null;

            using (var ctx = new CarServiceEntities())
            {
                workOrder = ctx.WorkOrders.Select(x => new WorkOrderViewModel()
                {
                    ID = x.ID,
                    CompanyID = x.CompanyID,
                    EmployeeID = x.EmployeeID,
                    VehicleID = x.VehicleID,
                    VehicleKm = x.VehicleKm,
                    DateTime = x.DateTime,
                    IsActive = x.IsActive,


                }).ToList();

                if (workOrder.Count == 0)
                {
                    return NotFound();
                }

                return Ok(workOrder);
            }
        }

        [Route("api/WorkOrder/GetByID")]
        [HttpGet]
        public IHttpActionResult GetByID(int id)
        {
            IList<WorkOrderViewModel> workOrderList = null;

            using (var ctx = new CarServiceEntities())
            {
                workOrderList = ctx.WorkOrders.Where(x => x.ID == id).Select(x => new WorkOrderViewModel()
                {
                    ID = x.ID,
                    CompanyID = x.CompanyID,
                    EmployeeID = x.EmployeeID,
                    VehicleID = x.VehicleID,
                    VehicleKm = x.VehicleKm,
                    DateTime = x.DateTime,
                    IsActive = x.IsActive,

                }).ToList();
            }

            if (workOrderList.Count == 0)
            {
                return NotFound();
            }

            return Ok(workOrderList);
        }
        [Route("api/WorkOrder/GetByVehicleID")]
        [HttpGet]
        public IHttpActionResult GetByVehicleID(int id)
        {
            IList<WorkOrderViewModel> workOrderList = null;

            using (var ctx = new CarServiceEntities())
            {
                workOrderList = ctx.WorkOrders.Where(x => x.VehicleID == id).Select(x => new WorkOrderViewModel()
                {
                    ID = x.ID,
                    CompanyID = x.CompanyID,
                    EmployeeID = x.EmployeeID,
                    VehicleID = x.VehicleID,
                    VehicleKm = x.VehicleKm,
                    DateTime = x.DateTime,
                    IsActive = x.IsActive,

                }).ToList();
            }

            if (workOrderList.Count == 0)
            {
                return NotFound();
            }

            return Ok(workOrderList);
        }

        [Route("api/WorkOrder/Insert")]
        [HttpPost]
        public IHttpActionResult InsertWorkOrder(WorkOrderViewModel newWorkOrder)
        {
            using (var ctx = new CarServiceEntities())
            {
                var workOrder = new WorkOrder
                {
                    CompanyID = newWorkOrder.CompanyID,
                    EmployeeID = newWorkOrder.EmployeeID,
                    VehicleID = newWorkOrder.VehicleID,
                    VehicleKm = newWorkOrder.VehicleKm,
                    DateTime = DateTime.Now,
                    IsActive = 1
                };

                ctx.WorkOrders.Add(workOrder);

                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/WorkOrder/Update")]
        [HttpPut]
        public IHttpActionResult UpdateWorkOrder(WorkOrderViewModel updateWorkOrder)
        {
            using (var ctx = new CarServiceEntities())
            {
                var workOrder = ctx.WorkOrders.Where(x => x.ID == updateWorkOrder.ID).SingleOrDefault();

                if (workOrder == null)
                {
                    return NotFound();
                }
                workOrder.CompanyID = updateWorkOrder.CompanyID;
                workOrder.EmployeeID = updateWorkOrder.EmployeeID;
                workOrder.VehicleID = updateWorkOrder.VehicleID;
                workOrder.VehicleKm = updateWorkOrder.VehicleKm;
                
                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/WorkOrder/DeactivateByID")]
        [HttpPut]
        public IHttpActionResult DeactivateWorkOrderByID(int id)
        {
            using (var ctx = new CarServiceEntities())
            {
                var workOrder = ctx.WorkOrders.Where(x => x.ID == id).FirstOrDefault();

                if (workOrder == null)
                {
                    return NotFound();
                }

                workOrder.IsActive = 0;

                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/WorkOrder/ActivateByID")]
        [HttpPut]
        public IHttpActionResult ActivateWorkOrderByID(int id)
        {
            using (var ctx = new CarServiceEntities())
            {
                var workOrder = ctx.WorkOrders.Where(x => x.ID == id).FirstOrDefault();

                if (workOrder == null)
                {
                    return NotFound();
                }

                workOrder.IsActive = 1;

                ctx.SaveChanges();
            }

            return Ok();
        }
        [Route("api/WorkOrder/DeleteByID")]
        [HttpDelete]
        public IHttpActionResult DeleteworkOrderById(int id)
        {
            using (var ctx = new CarServiceEntities())
            {
                var workOrder = ctx.WorkOrders.Where(x => x.ID == id).SingleOrDefault();

                if (workOrder == null)
                {
                    return NotFound();
                }

                ctx.WorkOrders.Remove(workOrder);

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}