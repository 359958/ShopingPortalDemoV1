using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingCart.Core.Model
{
    public class CoreProductsInfo
    {
        public int? ProductId { get; set; }
        public int? ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}
