using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingCart.Core.Model
{
    public class CoreProducts
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}
