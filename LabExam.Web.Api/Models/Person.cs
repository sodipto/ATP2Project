using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LabExam.Web.Api.Models
{
    [Table("Persons")]
    public class Person
    {
        public int Id { get; set; }

        public string name { get; set; }

        public DateTime dateOfBirth { get; set; }

        public int MobileId { get; set; }





    }
}