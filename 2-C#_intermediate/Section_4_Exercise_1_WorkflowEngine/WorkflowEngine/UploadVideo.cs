using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    internal class UploadVideo : IActivity
    {
        public UploadVideo() { 
        }

        public void Execute()
        {
            Console.WriteLine("# 'UploadVideo' object: executing");
        }
    }
}
