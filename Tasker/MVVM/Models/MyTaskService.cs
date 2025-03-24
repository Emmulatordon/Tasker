using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.MVVM.Models
{
    public class MyTaskService
    {
        public ObservableCollection<MyTask> GetAllTasks()
        { 
            return new ObservableCollection<MyTask>()
            {
                new MyTask(){TaskName="Upload exercise files",Completed=false,CategoryId=1},
                new MyTask(){TaskName="Plan next course",Completed=false,CategoryId=1},
                new MyTask(){TaskName="Plan next course",Completed=false,CategoryId=1},
                new MyTask(){TaskName="Upload new Asp.net course on youtube",Completed=false,CategoryId=2},
                new MyTask(){TaskName="Fix settings.cs file of the project",Completed=false,CategoryId=2},
                new MyTask(){TaskName="Update github repository",Completed=false,CategoryId=2},
                new MyTask(){TaskName="Find a laptop bag",Completed=false,CategoryId=3},
                new MyTask(){TaskName="Finish two beds",Completed=false,CategoryId=4},
            }; 
        }
    }
}
