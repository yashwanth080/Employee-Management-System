using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Employee
    {
        [Key]
        public int employeeid { get; set; }
        public string employeename { get; set; }
        public string email { get; set; }
        public string department { get; set; }
        public double salary { get; set; }
    }
}