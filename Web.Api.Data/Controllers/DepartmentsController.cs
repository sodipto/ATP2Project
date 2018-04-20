using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.Api.Data.Models;

namespace Web.Api.Data.Controllers
{
    public class DepartmentsController : ApiController
    {

        UmsDbContext db = new UmsDbContext();
        // GET: api/Departments

        string url = "http://localhost:50792/api/Departments/";

        public IEnumerable<Department> Get()
        {
            return db.Departments.ToList();
        }

        // GET: api/Departments/5
        public Department Get(int id)
        {
            return db.Departments.SingleOrDefault(x => x.Id == id);
        }

        // POST: api/Departments
        public IHttpActionResult Post([FromBody]Department dept)
        {

            db.Departments.Add(dept);
            db.SaveChanges();

            return Created(url + dept.Id,dept);

        }

        // PUT: api/Departments/5
        public IHttpActionResult Put(int id, [FromBody]Department dept)
        {
            Department deptToUpdate = db.Departments.Find(id);
            deptToUpdate.Name = dept.Name;
            deptToUpdate.Description = dept.Description;
            db.SaveChanges();

            return Content(HttpStatusCode.OK, deptToUpdate);


        }

        // DELETE: api/Departments/5
        public IHttpActionResult Delete(int id)
        {
            Department del = db.Departments.Find(id);

            db.Departments.Remove(del);

            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);

        }
    }
}
