using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShopingCart.Core.Model;

namespace ShopingCart.Service.Repositories.IService
{
    public interface IProducts
    {
        Task<List<CoreProducts>> GetAllProducts();
        Task<CoreProducts> GetProducts(string CoreProductId);
        Task<CoreProductsInfo> GetProductInfo(string CoreProductId);
    }
}
