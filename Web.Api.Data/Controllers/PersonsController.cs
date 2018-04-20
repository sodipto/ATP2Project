using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.Api.Data.Models;

namespace Web.Api.Data.Controllers
{
    public class PersonsController : ApiController
    {
        UmsDbContext db = new UmsDbContext();

        string url = "http://localhost:50792/api/Persons/";


        // GET: api/Persons
        public IEnumerable<Person> Get()
        {

            return db.Persons.ToList();

        }

        // GET: api/Persons/5
        public Person Get(int id)
        {
            return db.Persons.Find(id);
        }

        // POST: api/Persons
        public IHttpActionResult Post([FromBody]Person p)
        {

            db.Persons.Add(p);
            db.SaveChanges();

            return Created(url + p.Id, p);
        }

        // PUT: api/Persons/5
        public IHttpActionResult Put(int id, [FromBody]Person p)
        {
            Person pToUpdate = db.Persons.Find(id);

            pToUpdate.name = p.name;
            pToUpdate.dateOfBirth = p.dateOfBirth;
            db.SaveChanges();

            return Content(HttpStatusCode.OK, pToUpdate);
        }

        // DELETE: api/Persons/5
        public IHttpActionResult Delete(int id)


        {
            Person del = db.Persons.Find(id);

            db.Persons.Remove(del);

            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}

