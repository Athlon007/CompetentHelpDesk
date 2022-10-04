using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class ErrorHandler
    {
        const string OutputFile = "logs.txt";

        private static ErrorHandler instance;
        public static ErrorHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ErrorHandler();
                }
                return instance;
            }
        }

        /// <summary>
        /// Writes the error to the log file.
        /// </summary>
        /// <param name="ex"></param>
        public void WriteError(Exception ex)
        {
            string output = $"({DateTime.Now}) {ex.Message}:\n{ex.StackTrace}\n{new string('=', 20)}";
            StreamWriter sw = new StreamWriter(OutputFile, true);
            sw.WriteLine(output);
            sw.Close();
        }
    }
}
