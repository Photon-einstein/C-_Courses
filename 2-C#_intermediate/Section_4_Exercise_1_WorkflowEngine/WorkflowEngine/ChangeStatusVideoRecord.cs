using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    internal class ChangeStatusVideoRecord : IActivity
    {
        public ChangeStatusVideoRecord()
        {
                
        }

        public void Execute()
        {
            Console.WriteLine("# 'ChangeStatusVideoRecord' object: executing");
        }
    }
}
