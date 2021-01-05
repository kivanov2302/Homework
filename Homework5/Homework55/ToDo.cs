using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework55
{
    [Serializable]
    public class Task
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public Task(string title, bool isDone)
        {
            Title = title;
            IsDone = isDone;
        }
        public Task()
        {
            Title = "";
            IsDone = false;
        }
    }
}
