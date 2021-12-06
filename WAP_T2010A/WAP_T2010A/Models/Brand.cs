using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WAP_T2010A.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui long nhap ten thuong hieu")]
        public string BrandName { get; set; }
        [Required(ErrorMessage = "Vui long nhap anh thuong hieu")]
        public string BrandImage { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}