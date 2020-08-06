using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ShopingCart.Core.Model;
using ShopingCart.Api.CoreEntity;

namespace ShopingCart.Core.MappingProfile
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<CoreProducts, ProductEntity>().ReverseMap();
            CreateMap<CoreProductsInfo, ProductInfoEntity>();
        }
    }
}
