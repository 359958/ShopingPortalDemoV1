using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingCart.Api.CoreEntity
{
    public class ProductInfoEntity
    {
        public int? ProductId { get; set; }
        public int? ProductPrice { get; set; }
        public string ProductDescription { get; set; }
    }
}
