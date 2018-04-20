using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LabExam.Web.Api.Models
{
    public class PersonContext:DbContext

    {

        public DbSet<Person> Persons { get; set; }
        public DbSet<Mobile> Mobiles { get; set; }



    }
}