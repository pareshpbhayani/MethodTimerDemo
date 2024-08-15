using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MethodTimerDemo
{
    public static class MethodTimeLogger
    {
        public static void Log(MethodBase methodBase, long milliseconds, string message)
        {
            //Write to VS Debug Output window, logger, etc...
            Debug.WriteLine($"Time Ms: {milliseconds}");
        }
    }
}
