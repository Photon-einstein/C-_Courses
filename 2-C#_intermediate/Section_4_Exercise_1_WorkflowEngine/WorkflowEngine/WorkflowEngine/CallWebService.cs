using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    internal class CallWebService : IActivity
    {
        public CallWebService() { 
        }

        public void Execute()
        {
            Console.WriteLine("# 'CallWebService' object: executing");
        }
    }
}
