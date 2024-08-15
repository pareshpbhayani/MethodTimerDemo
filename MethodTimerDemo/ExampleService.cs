using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodTimer;

namespace MethodTimerDemo
{
    public class ExampleService
    {
        [Time]
        public void ProcessData()
        {
            // Simulate some work
            System.Threading.Thread.Sleep(2000);
        }
    }

}
