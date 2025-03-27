using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.MVVM.Models;

namespace Tasker.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]

    public class MainViewModel
    {
        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<MyTask> Tasks { get; set; }
        public MainViewModel()
        {            
            FillData();
            UpdateData();
        }

        public void UpdateData()
        {
            foreach (var c in Categories)
            {
                var tasks = from t in Tasks where t.CategoryId == c.Id select t;    
                var completed = from t in tasks where t.Completed == true select t;    
                var notCompleted = from t in tasks where t.Completed == false select t;  
                c.PendingTasks = notCompleted.Count();
                c.Percentage = (float)completed.Count()/ (float)tasks.Count();
            }
            foreach (var t in Tasks)
            {
                var catColor = (from c in Categories where c.Id == t.CategoryId select c.Color).FirstOrDefault();
                t.TaskColor = catColor;
            }
        }       
        private void FillData()
        {          
            Tasks =  new MyTaskService().GetAllTasks();
            Categories = new CategoryService().GetAllCategories();
        }

    }
}
