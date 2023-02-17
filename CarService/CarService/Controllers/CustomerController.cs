using CarService.ViewModels;
using CarService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CarService.Controllers
{
    public class CustomerController : ApiController
    {
        [Route("api/Customer")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            IList<CustomerViewModel> customerList = null;

            using (var ctx = new CarServiceEntities())
            {
                customerList = ctx.Customers.Select(x => new CustomerViewModel()
                {
                    ID = x.ID,
                    CompanyID = x.CompanyID,
                    Name = x.Name,
                    Surname = x.Surname,
                    Address = x.Address,
                    City = x.City,
                    OIB = x.OIB,
                    Contact = x.Contact,
                    Email = x.Email,
                    Since = x.Since,
                    IsActive = x.IsActive

                }).ToList();

                if (customerList.Count == 0)
                {
                    return NotFound();
                }

                return Ok(customerList);
            }
        }

        [Route("api/Customer/GetByID")]
        [HttpGet]
        public IHttpActionResult GetByID(int id)
        {
            IList<CustomerViewModel> customerList = null;

            using (var ctx = new CarServiceEntities())
            {
                customerList = ctx.Customers.Where(x => x.ID == id).Select(x => new CustomerViewModel()
                {
                    ID = x.ID,
                    CompanyID = x.CompanyID,
                    Name = x.Name,
                    Surname = x.Surname,
                    Address = x.Address,
                    City = x.City,
                    OIB = x.OIB,
                    Contact = x.Contact,
                    Email = x.Email,
                    Since = x.Since,
                    IsActive = x.IsActive
                }).ToList();
            }

            if (customerList.Count == 0)
            {
                return NotFound();
            }

            return Ok(customerList);
        }

        [Route("api/Customer/GetByCompanyID")]
        [HttpGet]
        public IHttpActionResult GetByCompanyID(int id)
        {
            IList<CustomerViewModel> customerList = null;

            using (var ctx = new CarServiceEntities())
            {
                customerList = ctx.Customers.Where(x => x.CompanyID == id).Select(x => new CustomerViewModel()
                {
                    ID = x.ID,
                    CompanyID = x.CompanyID,
                    Name = x.Name,
                    Surname = x.Surname,
                    Address = x.Address,
                    City = x.City,
                    OIB = x.OIB,
                    Contact = x.Contact,
                    Email = x.Email,
                    Since = x.Since,
                    IsActive = x.IsActive
                }).ToList();
            }

            if (customerList.Count == 0)
            {
                return NotFound();
            }

            return Ok(customerList);
        }

        [Route("api/Customer/Insert")]
        [HttpPost]
        public IHttpActionResult InsertCustomer(CustomerViewModel newCustomer)
        {
            using (var ctx = new CarServiceEntities())
            {
                var customer = new Customer
                {
                    CompanyID = newCustomer.CompanyID,
                    Name = newCustomer.Name,
                    Surname = newCustomer.Surname,
                    Address = newCustomer.Address,
                    City = newCustomer.City,
                    OIB = newCustomer.OIB,
                    Contact = newCustomer.Contact,
                    Email = newCustomer.Email,
                    Since = DateTime.Now,
                    IsActive = 1
                };

                ctx.Customers.Add(customer);

                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Customer/Update")]
        [HttpPut]
        public IHttpActionResult UpdateCustomer(CustomerViewModel updateCustomer)
        {
            using (var ctx = new CarServiceEntities())
            {
                var customer = ctx.Customers.Where(x => x.ID == updateCustomer.ID).SingleOrDefault();

                if (customer == null)
                {
                    return NotFound();
                }
                customer.CompanyID = updateCustomer.CompanyID;
                customer.Name = updateCustomer.Name;
                customer.Surname = updateCustomer.Surname;
                customer.Address = updateCustomer.Address;
                customer.City = updateCustomer.City;
                customer.OIB = updateCustomer.OIB;
                customer.Contact = updateCustomer.Contact;
                customer.Email = updateCustomer.Email;
                customer.IsActive = updateCustomer.IsActive;
              
                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Customer/DeleteByID")]
        [HttpDelete]
        public IHttpActionResult DeleteCustomerById(int id)
        {
            using (var ctx = new CarServiceEntities())
            {
                var customer = ctx.Customers.Where(x => x.ID == id).SingleOrDefault();

                if (customer == null)
                {
                    return NotFound();
                }

                ctx.Customers.Remove(customer);

                ctx.SaveChanges();
            }

            return Ok();
        }

        //[Route("api/Customer/DeactivateByID")]
        //[HttpPut]
        //public IHttpActionResult DeactivateCustomerByID(int id)
        //{
        //    using (var ctx = new CarServiceEntities())
        //    {
        //        var customer = ctx.Customers.Where(x => x.ID == id).FirstOrDefault();

        //        if (customer == null)
        //        {
        //            return NotFound();
        //        }

        //        customer.IsActive = 0;

        //        ctx.SaveChanges();
        //    }

        //    return Ok();
        //}

        //[Route("api/Customer/ActivateByID")]
        //[HttpPut]
        //public IHttpActionResult ActivateCustomerByID(int id)
        //{
        //    using (var ctx = new CarServiceEntities())
        //    {
        //        var customer = ctx.Customers.Where(x => x.ID == id).FirstOrDefault();

        //        if (customer == null)
        //        {
        //            return NotFound();
        //        }

        //        customer.IsActive = 1;

        //        ctx.SaveChanges();
        //    }

        //    return Ok();
        //}


    }
}