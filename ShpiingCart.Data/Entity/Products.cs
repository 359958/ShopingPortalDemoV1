using System;
using System.Collections.Generic;

namespace ShpiingCart.Data.Models
{
    public partial class Products
    {
        public Products()
        {
            ProductsInfo = new HashSet<ProductsInfo>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? Lastupdate { get; set; }

        public virtual ICollection<ProductsInfo> ProductsInfo { get; set; }
    }
}
