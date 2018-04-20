using LabExam.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LabExam.Web.Api.Controllers
{
    public class MobileController : ApiController
    {

        PersonContext ctx = new PersonContext();
        // GET api/mobile

        string url = "http://localhost:49567/api/Mobile/";


        public IEnumerable<Mobile> Get()
        {
            return ctx.Mobiles.ToList();
        }

        // GET api/mobile/5
        public Mobile Get(int id)
        {
            Mobile mob = ctx.Mobiles.SingleOrDefault(s => s.id== id);
            return mob;
        }

        // POST api/mobile
        public IHttpActionResult Post([FromBody]Mobile mobile)
        {
            ctx.Mobiles.Add(mobile);
            ctx.SaveChanges();
            return Created(url + mobile.id, mobile);

        }

        // PUT api/mobile/5
        public IHttpActionResult Put(int id, [FromBody]Mobile mobile)
        {
            Mobile mobiletoupdate = ctx.Mobiles.Find(id);
            mobiletoupdate.number = mobile.number;
            mobiletoupdate.operators = mobile.operators;
            mobiletoupdate.CountryCode = mobile.CountryCode;

            ctx.SaveChanges();
            return Content(HttpStatusCode.OK, mobiletoupdate);
        }

        // DELETE api/mobile/5
        public IHttpActionResult Delete(int id)
        {
            Mobile mobiletodelete = ctx.Mobiles.Find(id);
            ctx.Mobiles.Remove(mobiletodelete);
            ctx.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }



    }
}
