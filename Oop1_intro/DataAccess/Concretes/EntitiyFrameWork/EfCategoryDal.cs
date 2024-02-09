using Oop1_intro.DataAccess.Abstruct;
using Oop1_intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1_intro.DataAccess.Concretes.EntitiyFrameWork;
public class EfCategoryDal : ICategoryDal
{
    List<Category> categories = new List<Category>();
    public EfCategoryDal()
    {

        categories.Add(new Category
        {
            Id = 1,
            Name = "Market",

        });
        categories.Add(new Category
        {
            Id = 2,
            Name = "Mağaza",

        });
        categories.Add(new Category
        {
            Id = 3,
            Name = "Elektronik",

        });

    }
    public void Add(Category category)
    {
        categories.Add(category);
    }
    public List<Category> GetCategories()
    {
        return categories;
    }
}
