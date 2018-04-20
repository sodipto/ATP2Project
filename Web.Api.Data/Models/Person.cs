using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Api.Data.Models
{  

    [Table("Persons")]
    public class Person
    {
        public int Id { get; set; }

        public string name { get; set; }

        public string dateOfBirth { get; set; }
    }
}