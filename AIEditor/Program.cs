using AIEditor.Services;
using Python.Runtime;

namespace AIEditor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
            PythonEngine.Shutdown();
        }
    }
}