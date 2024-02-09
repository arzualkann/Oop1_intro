using Oop1_intro.DataAccess.Abstruct;
using Oop1_intro.DataAccess.Concretes.InMemory;
using Oop1_intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1_intro.Business.Concretes;

public class CategoryManager
{
    ICategoryDal _categoryDal;
    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }
    public void Add(Category category)
    {
        //business rules
        _categoryDal.Add(category);
    }
    public List<Category> GetCategories()
    {
        return _categoryDal.GetCategories();
    }
}
