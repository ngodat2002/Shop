using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WAP_T2010A.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Vui long nhap ten danh muc")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage ="Vui long nhap anh danh muc")]
        public string CategoryImage { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}