using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    internal class SendEmail : IActivity
    {
        public SendEmail()
        {

        }
        public void Execute()
        {
            Console.WriteLine("# 'SendEmail' object: executing");
        }
    }
}
