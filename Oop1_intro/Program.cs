using Oop1_intro.Business.Concretes;
using Oop1_intro.DataAccess.Concretes.InMemory;
using Oop1_intro.Entities;

namespace Oop1_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Product product1 = new Product(); //referans oluşturma
            product1.Id = 1;
            product1.Name = "Laptop";
            product1.Description = "Aşırı güçlü bir laptop";
            product1.UnitPrice = 50000;
            product1.DiscountRate = 10; //referans değeri verme

            Product product2 = new Product(2, "GSM", "Samsung bişey", 70000);


            ProductManager productManager = new ProductManager(new ImProductDal());
            productManager.Add(product2);
            foreach (var product in productManager.GetProducts())
            {
                Console.WriteLine(product.Name);
            }

            Category category1 = new Category(4, "xxx");

            CategoryManager categoryManager = new CategoryManager(new ImCategoryDal());
            categoryManager.Add(category1);

            foreach (var category in categoryManager.GetCategories())
            {
                Console.WriteLine(category.Name);
            }
        }
    }
}
