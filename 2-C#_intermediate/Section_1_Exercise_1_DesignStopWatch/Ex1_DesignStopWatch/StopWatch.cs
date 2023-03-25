using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex1_DesignStopWatch
{
    internal class StopWatch
    {
        private TimeSpan _stopWatchInterval { get; set; } 
        
        private DateTime _stopTime { get; set; }    
        private DateTime _startTime {get; set;}
        private int _stateMachineStart { get; set; } = 0; /* 0 - not started, 1-started */

        public StopWatch()
        {

        }

        public void Start ()
        {
            if (_stateMachineStart != 0)
            {
                _stateMachineStart = 0;
                throw new InvalidOperationException("Start timer cannot be started twice in a row.");
            }
            else
            {
                _startTime = DateTime.Now;
                _stateMachineStart = 1;
            }
        }

        public void Stop ()
        {
            _stopTime = DateTime.Now;
            _stateMachineStart = 0;
        }

        public void Duration ()
        {
             _stopWatchInterval = _stopTime - _startTime;
            Console.WriteLine("The duration of the time was {0}.{1} s.", _stopWatchInterval.Seconds, _stopWatchInterval.Milliseconds);
            return;
        }

    }
}
