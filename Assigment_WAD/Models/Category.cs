using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Assigment_WAD.Models
{
    public class Category
    {
        public int ID { get; set; }
        [DisplayName("Danh mục sản phẩm")]
        public string Name { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}