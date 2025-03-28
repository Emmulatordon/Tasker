using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.MVVM.Models;
using System.Collections.ObjectModel;



namespace Tasker.MVVM.ViewModels
{
    public class NewTaskViewModel
    {
        public string TaskName { get; set; }    
        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<MyTask> Tasks { get; set; }
    }
}
