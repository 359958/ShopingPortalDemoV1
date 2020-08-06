using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShopingCart.Core.Model;
using ShopingCart.Service.Repositories.IService;
using ShpiingCart.Data;
using ShpiingCart.Data.Models;
using Microsoft.EntityFrameworkCore;
using ShopingCart.Core.Service;
using System.Linq;

namespace ShopingCart.Service.Repositories
{
    public class Products : IProductServices
    {
        private readonly ShopingDBContext _shopingDBContext;
         
        public Products(ShopingDBContext shopingDBContext)
        {
            this._shopingDBContext = shopingDBContext;
        }
        public  List<CoreProducts> GetAllProducts()
        {
            var Products =  _shopingDBContext
                                            .Products.Select(o => new CoreProducts
                                            {
                                                ProductId = o.ProductId,
                                                ProductName = o.ProductName
                                            }).ToList();
            return Products;
        }

        public Task<CoreProductsInfo> GetProductInfo(string CoreProductId)
        {
            throw new NotImplementedException();
        }

        public Task<CoreProducts> GetProducts(string CoreProductId)
        {
            throw new NotImplementedException();
        }
    }
}
