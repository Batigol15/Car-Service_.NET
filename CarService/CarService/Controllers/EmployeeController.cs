using CarService.ViewModels;
using CarService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CarService.Controllers
{
    public class EmployeeController : ApiController
    {
        [Route("api/Employee")]
        [HttpGet]

        public IHttpActionResult Get()
        {
            IList<EmployeeViewModel> employeeList = null;

            using (var ctx = new CarServiceEntities())
            {
                employeeList = ctx.Employees.Select(x => new EmployeeViewModel()
                {
                    ID = x.ID,
                    CompanyID = x.CompanyID,
                    Name = x.Name,
                    Surname = x.Surname,
                    Password = x.Password,
                    OIB = x.OIB,
                    Contact = x.Contact,
                    Since = x.Since,
                    IsActive = x.IsActive

                }).ToList();

                if (employeeList.Count == 0)
                {
                    return NotFound();
                }

                return Ok(employeeList);
            }
        }

        [Route("api/Employee/GetByID")]
        [HttpGet]
        public IHttpActionResult GetByID(int id)
        {
            IList<EmployeeViewModel> employeeList = null;

            using (var ctx = new CarServiceEntities())
            {
                employeeList = ctx.Employees.Where(x => x.ID == id).Select(x => new EmployeeViewModel()
                {
                    ID = x.ID,
                    CompanyID = x.CompanyID,
                    Name = x.Name,
                    Surname = x.Surname,
                    Password = x.Password,
                    OIB = x.OIB,
                    Contact = x.Contact,
                    Since = x.Since,
                    IsActive = x.IsActive

                }).ToList();
            }

            if (employeeList.Count == 0)
            {
                return NotFound();
            }

            return Ok(employeeList);
        }

        [Route("api/Employee/GetByCompanyID")]
        [HttpGet]
        public IHttpActionResult GetByCompanyID(int id)
        {
            IList<EmployeeViewModel> employeeList = null;

            using (var ctx = new CarServiceEntities())
            {
                employeeList = ctx.Employees.Where(x => x.CompanyID == id).Select(x => new EmployeeViewModel()
                {
                    ID = x.ID,
                    CompanyID = x.CompanyID,
                    Name = x.Name,
                    Surname = x.Surname,
                    Password = x.Password,
                    OIB = x.OIB,
                    Contact = x.Contact,
                    Since = x.Since,
                    IsActive = x.IsActive

                }).ToList();
            }

            if (employeeList.Count == 0)
            {
                return NotFound();
            }

            return Ok(employeeList);
        }

        [Route("api/Employee/Insert")]
        [HttpPost]
        public IHttpActionResult InsertEmployee(EmployeeViewModel newEmployee)
        {
            using (var ctx = new CarServiceEntities())
            {
                var employee = new Employee
                {
                    CompanyID = newEmployee.CompanyID,
                    Name = newEmployee.Name,
                    Surname = newEmployee.Surname,
                    Password = newEmployee.Password,
                    OIB = newEmployee.OIB,
                    Contact = newEmployee.Contact,
                    Since = DateTime.Now,
                    IsActive = 1
                };


                ctx.Employees.Add(employee);

                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Employee/Update")]
        [HttpPut]
        public IHttpActionResult UpdateEmployee(EmployeeViewModel updateEmployee)
        {
            using (var ctx = new CarServiceEntities())
            {
                var employee = ctx.Employees.Where(x => x.ID == updateEmployee.ID).SingleOrDefault();

                if (employee == null)
                {
                    return NotFound();
                }
                employee.Name = updateEmployee.Name;
                employee.Surname = updateEmployee.Surname;
                employee.Password = updateEmployee.Password;
                employee.OIB = updateEmployee.OIB;
                employee.Contact = updateEmployee.Contact;
                employee.IsActive = updateEmployee.IsActive;

                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Employee/DeactivateByID")]
        [HttpPut]
        public IHttpActionResult DeactivateEmployeeByID(int id)
        {
            using (var ctx = new CarServiceEntities())
            {
                var employee = ctx.Employees.Where(x => x.ID == id).FirstOrDefault();

                if (employee == null)
                {
                    return NotFound();
                }

                employee.IsActive = 0;

                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Employee/ActivateByID")]
        [HttpPut]
        public IHttpActionResult ActivateEmployeeByID(int id)
        {
            using (var ctx = new CarServiceEntities())
            {
                var employee = ctx.Employees.Where(x => x.ID == id).FirstOrDefault();

                if (employee == null)
                {
                    return NotFound();
                }

                employee.IsActive = 1;

                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Employee/DeleteByID")]
        [HttpDelete]
        public IHttpActionResult DeleteEmployeeById(int id)
        {
            using (var ctx = new CarServiceEntities())
            {
                var employee = ctx.Employees.Where(x => x.ID == id).SingleOrDefault();

                if (employee == null)
                {
                    return NotFound();
                }

                ctx.Employees.Remove(employee);

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}