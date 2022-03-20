using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Assigment_WAD.Models
{
    public class ShoppingCart
    {
        
        public int ProductId { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string ProductName { get; set; }
        [DisplayName("Số lượng sản phẩm")]
        public int Amout { get; set; }
        [DisplayName("Đơn giá")]
        public double Prices { get; set; }
        [DisplayName("Tổng giá")]
        public double TotalPrice { get; set; }
        [DisplayName("Ảnh sản phẩm")]
        public string Thumbnail { get; set; }
    }
}