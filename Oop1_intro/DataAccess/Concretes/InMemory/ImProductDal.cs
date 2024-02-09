using Oop1_intro.DataAccess.Abstruct;
using Oop1_intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1_intro.DataAccess.Concretes.InMemory;
public class ImProductDal : IProductDal
{
    List<Product> products = new List<Product>();
    public ImProductDal()
    {

        products.Add(new Product
        {
            Id = 1,
            Name = "Elma",
            UnitPrice = 10,
            Description = "Kırmızı Elma",
            DiscountRate = 10
        });

    }
    public void Add(Product product)
    {
        products.Add(product);
    }
    public List<Product> GetProducts()
    {
        return products;
    }


}

