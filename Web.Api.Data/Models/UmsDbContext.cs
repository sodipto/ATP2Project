using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.Api.Data.Models
{
    public class UmsDbContext:DbContext
    {

        public DbSet<Person>Persons { get; set; }

    }
}