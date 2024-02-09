using Oop1_intro.DataAccess.Abstruct;
using Oop1_intro.DataAccess.Concretes.InMemory;
using Oop1_intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1_intro.Business.Concretes;
public class ProductManager
{
    IProductDal _productDal;
    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }
    public void Add(Product product)
    {
        //business rules
        _productDal.Add(product);
    }
    public List<Product> GetProducts()
    {
        return _productDal.GetProducts();
    }
}
