using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.MVVM.Models
{
   public class CategoryService
    {
        public ObservableCollection<Category> GetAllCategories()
        {
            return new ObservableCollection<Category>()
            {
                new Category(){Id=1,CategoryName=".Net MAUI Course",Color="#cf14df"},
                new Category(){Id=2,CategoryName="Tutorials",Color="#df6f14"},
                new Category(){Id=3,CategoryName="Shopping",Color="#14df80"},
                new Category(){Id=4,CategoryName="Farming",Color="#14b680"}

            };
        }
    }
}
