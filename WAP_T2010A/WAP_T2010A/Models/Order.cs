using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WAP_T2010A.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int Code { get; set; }
        public string GoodsName { get; set; }
        public int price { get; set; }
    }
}