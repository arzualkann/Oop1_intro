using Oop1_intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1_intro.DataAccess.Abstruct;

    public interface ICategoryDal
    {
        void Add(Category category);
        List<Category> GetCategories();
    }

