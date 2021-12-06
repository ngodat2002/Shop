using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WAP_T2010A.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public int Phone { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Date { get; set; }
    }
}