using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopingCart.Core.Service;
using ShopingCart.Api.CoreEntity;
using ShopingCart.Core.Model;
using AutoMapper;
 


namespace ShopingCart.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _productMapper;
        private readonly IProductServices _productService;

        public ProductController(IProductServices productServices , IMapper productMapper)
        {
            _productService = productServices;
            _productMapper = productMapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllProducts()
        {
            
                var Products = _productService.GetAllProducts();
                List<ProductEntity> ProductList = _productMapper.Map<List<CoreProducts>,List<ProductEntity>>(Products);
                return Ok(ProductList);  
           
        } 
    }
}