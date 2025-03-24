using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.MVVM.Models;

namespace Tasker.MVVM.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Category> Categories { get; set; }
        public MainViewModel()
        {
            Categories = FillData();
        }

        private ObservableCollection<Category> FillData()
        {
            return new CategoryService().GetAllCategories();
        }
    }
}
