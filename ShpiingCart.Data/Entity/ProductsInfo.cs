using System;
using System.Collections.Generic;

namespace ShpiingCart.Data.Models
{
    public partial class ProductsInfo
    {
        public int Sno { get; set; }
        public int? ProductId { get; set; }
        public int? ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? Lastupdate { get; set; }

        public virtual Products Product { get; set; }
    }
}
