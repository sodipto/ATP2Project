using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LabExam.Web.Api.Models
{

    [Table("Mobiles")]
    public class Mobile
    {

        public int id { get; set; }
        public string CountryCode { get; set; }
        public int number { get; set; }
        public string operators { get; set;}


    }
}