using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;

namespace AIEditor.Services
{
    public static class PythonContext
    {
        public static string PythonDLL { get; set; } = @"aieditor\python39.dll";
        public static string PythonHome { get; set; } = @"aieditor";

        public static bool IsInitialize = false;

        public static void Initialize()
        {
            if (IsInitialize) return;
            Runtime.PythonDLL = PythonDLL;
            PythonEngine.PythonHome = PythonHome;
            PythonEngine.Initialize();
            PythonEngine.BeginAllowThreads();
            IsInitialize = true;
        }
    }
}
