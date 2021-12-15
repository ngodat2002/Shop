using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace T2010A_WAD.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui long nhap ten san pham")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Vui long nhap chi tiet san pham")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Vui long nhap gia san pham")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Vui long nhap anh san pham")]
        public int CategoryID { get; set; }
        public int BrandID { get; set; }
        public virtual Category Category { get; set; }
        public virtual Brand Brand { get; set; }
    }
}