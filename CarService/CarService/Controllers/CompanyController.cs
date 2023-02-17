using CarService.ViewModels;
using CarService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CarService.Controllers
{
    public class CompanyController : ApiController
    {
        [Route("api/Company")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            IList<CompanyViewModel> companyList = null;

            using (var ctx = new CarServiceEntities())
            {
                companyList = ctx.Companies.Select(x => new CompanyViewModel()
                {
                    ID = x.ID,
                    Name = x.Name,
                    Address = x.Address,
                    City = x.City,
                    Contact = x.Contact,
                    Email = x.Email,
                    Since = x.Since,
                    IsActive = x.IsActive

                }).ToList();

                if (companyList.Count == 0)
                {
                    return NotFound();
                }

                return Ok(companyList);
            }
        }

        [Route("api/Company/GetByID")]
        [HttpGet]
        public IHttpActionResult GetByID(int id)
        {
            IList<CompanyViewModel> companyList = null;

            using (var ctx = new CarServiceEntities())
            {
                companyList = ctx.Companies.Where(x => x.ID == id).Select(x => new CompanyViewModel()
                {
                    ID = x.ID,
                    Name = x.Name,
                    Address = x.Address,
                    City = x.City,
                    Contact = x.Contact,
                    Email = x.Email,
                    Since = x.Since,
                    IsActive = x.IsActive
                }).ToList();
            }

            if (companyList.Count == 0)
            {
                return NotFound();
            }

            return Ok(companyList);
        }

        [Route("api/Company/Insert")]
        [HttpPost]
        public IHttpActionResult InsertCompany(CompanyViewModel newCompany)
        {
            using (var ctx = new CarServiceEntities())
            {
                var company = new Company
                {
                    Name = newCompany.Name,
                    Address = newCompany.Address,
                    City = newCompany.City,
                    Contact = newCompany.Contact,
                    Email = newCompany.Email,
                    Since = DateTime.Now,
                    IsActive = 1
                };

                ctx.Companies.Add(company);

                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Company/Update")]
        [HttpPut]
        public IHttpActionResult UpdateCompany(CompanyViewModel updateCompany)
        {
            using (var ctx = new CarServiceEntities())
            {
                var company = ctx.Companies.Where(x => x.ID == updateCompany.ID).SingleOrDefault();

                if (company == null)
                {
                    return NotFound();
                }
                company.ID = updateCompany.ID;
                company.Name = updateCompany.Name;
                company.Address = updateCompany.Address;
                company.City = updateCompany.City;
                company.Contact = updateCompany.Contact;
                company.Email = updateCompany.Email;
                               
                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Company/DeactivateByID")]
        [HttpPut]
        public IHttpActionResult DeactivateCompanyByID(int id)
        {
            using (var ctx = new CarServiceEntities())
            {
                var company = ctx.Companies.Where(x => x.ID == id).FirstOrDefault();

                if (company == null)
                {
                    return NotFound();
                }
              
                company.IsActive = 0;

                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Company/ActivateByID")]
        [HttpPut]
        public IHttpActionResult ActivateCompanyByID(int id)
        {
            using (var ctx = new CarServiceEntities())
            {
                var company = ctx.Companies.Where(x => x.ID == id).FirstOrDefault();

                if (company == null)
                {
                    return NotFound();
                }

                company.IsActive = 1;

                ctx.SaveChanges();
            }

            return Ok();
        }

        [Route("api/Company/DeleteByID")]
        [HttpDelete] //mislim da nece tribat
        public IHttpActionResult DeleteCompanyById(int id)
        {
            using (var ctx = new CarServiceEntities())
            {
                var company = ctx.Companies.Where(x => x.ID == id).SingleOrDefault();

                if (company == null)
                {
                    return NotFound();
                }

                ctx.Companies.Remove(company);

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}


    