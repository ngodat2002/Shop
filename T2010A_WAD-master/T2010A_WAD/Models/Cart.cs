using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T2010A_WAD.Models
{
    public class Cart
    {
        public int GrandTotal { get; set; }
        public List<CartItem> Items { get; set; }
        public void CalculateGrandTotal()
        {
            int grand = 0;

            foreach (var i in Items)
            {
                grand += i.Qty*i.Product.Price;

            }
            GrandTotal = grand;
        }
        public void AddToCart(CartItem item)
        {
            //Kiem tra xme sp da co trong gio hang hay chua, neu co roi chi them so lupong
            //neu chua moi them ngueyn ietem vao gio hang
            bool flag = false;
            foreach(var i in Items)
            {
                if(item.Product.Id== i.Product.Id)
                {
                    flag = true;
                    i.Qty += item.Qty;

                }
            }
            if (!flag)
            {
                Items.Add(item);
            }
            CalculateGrandTotal();
        }
    }
    public class CartItem
    {
        public Product Product { get; set; }
        public int Qty { get; set; }

    }
}