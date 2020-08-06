using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShopingCart.Core;
using ShopingCart.Core.Model;

namespace ShopingCart.Core.Service
{
    public interface IProductServices
    {
        List<CoreProducts> GetAllProducts();
        Task<CoreProducts> GetProducts(string CoreProductId);
        Task<CoreProductsInfo> GetProductInfo(string CoreProductId);
    }
}
