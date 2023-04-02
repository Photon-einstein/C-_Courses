using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    internal class WorkflowEngine
    {
        private List<IActivity> _activitys { get; set; }
        public WorkflowEngine()
        {
            _activitys= new List<IActivity>();
        }

        public void AddActivity(IActivity a)
        {
            if (a == null)
            {
                throw new ArgumentNullException("IActivity cannot be null.");
            } 
            _activitys.Add(a);
        }

        public void Run()
        {
            foreach (var activity in _activitys)
            {
                activity.Execute();
            }
        }
    }
}
