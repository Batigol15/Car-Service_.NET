using CarService.ViewModels;
using CarService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CarService.Controllers
{
    public class InvoiceController : ApiController
    {
        [Route("api/Invoice")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            IList<InvoiceViewModel> invoiceList = null;

            using (var ctx = new CarServiceEntities())
            {
                invoiceList = ctx.Invoices.Select(x => new InvoiceViewModel()
                {
                    ID = x.ID,
                    CompanyID = x.CompanyID,
                    WorkOrderID = x.WorkOrderID,
                    TotalPrice = x.TotalPrice,
                    DateTime = x.DateTime,


                }).ToList();

                if (invoiceList.Count == 0)
                {
                    return NotFound();
                }

                return Ok(invoiceList);
            }
        }
        [Route("api/Invoice/GetByID")]
        [HttpGet]
        public IHttpActionResult GetByID(int id)
        {
            IList<InvoiceViewModel> invoiceList = null;

            using (var ctx = new CarServiceEntities())
            {
                invoiceList = ctx.Invoices.Where(x => x.ID == id).Select(x => new InvoiceViewModel()
                {
                    ID = x.ID,
                    CompanyID = x.CompanyID,
                    WorkOrderID = x.WorkOrderID,
                    TotalPrice = x.TotalPrice,
                    DateTime = x.DateTime,

                }).ToList();
            }

            if (invoiceList.Count == 0)
            {
                return NotFound();
            }

            return Ok(invoiceList);
        }

        [Route("api/Invoice/GetByCompanyID")]
        [HttpGet]
        public IHttpActionResult GetByCompanyID(int id)
        {
            IList<InvoiceViewModel> invoiceList = null;

            using (var ctx = new CarServiceEntities())
            {
                invoiceList = ctx.Invoices.Where(x => x.CompanyID == id).Select(x => new InvoiceViewModel()
                {
                    ID = x.ID,
                    CompanyID = x.CompanyID,
                    WorkOrderID = x.WorkOrderID,
                    TotalPrice = x.TotalPrice,
                    DateTime = x.DateTime,

                }).ToList();
            }

            if (invoiceList.Count == 0)
            {
                return NotFound();
            }

            return Ok(invoiceList);
        }

        [Route("api/Invoice/Insert")]
        [HttpPost]
        public IHttpActionResult InsertInvoice(InvoiceViewModel newInvoice)
        {
            using (var ctx = new CarServiceEntities())
            {
                var invoice = new Invoice
                {
                    CompanyID = newInvoice.CompanyID,
                    WorkOrderID = newInvoice.WorkOrderID,
                    TotalPrice = newInvoice.TotalPrice,
                    DateTime = DateTime.Now
                };



                ctx.Invoices.Add(invoice);

                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Invoice/DeleteByID")]
        [HttpDelete]
        public IHttpActionResult DeleteInvoiceById(int id)
        {
            using (var ctx = new CarServiceEntities())
            {
                var invoice = ctx.Invoices.Where(x => x.ID == id).SingleOrDefault();

                if (invoice == null)
                {
                    return NotFound();
                }

                ctx.Invoices.Remove(invoice);

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}