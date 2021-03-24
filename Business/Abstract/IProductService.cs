using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllbyCategoryId(int id);
        List<Product> GetAllByUnitPrice(decimal min, decimal max);
    }
}