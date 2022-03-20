using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Assigment_WAD.Models
{
    public class Product
    {

        [DisplayName("Mã sản phẩm")]
        public int Id { get; set; }
        public int CategoryID { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }
        [DisplayName("Miêu tả sản phẩm")]
        public string Description { get; set; }
        [DisplayName("Sản phẩm chi tiết")]
        public string Detail { get; set; }
        [DisplayName("Ảnh sản phẩm")]
        public string Thumbnail { get; set; }
        [DisplayName("Giá tiền")]
        public double Prices { get; set; }
        public virtual Category Category { get; set; }
    }
}