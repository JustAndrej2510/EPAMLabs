using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatrade.Utils
{
    public static class Logger
    {
        public static ILogger logger = new LoggerConfiguration()
           .WriteTo.Console()
           .WriteTo.File(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName +
                   "/Avatrade/Logs/LogInfo.log")
           .CreateLogger();

        public static void WriteToLog(string message)
        {
            logger.Information(message);
        }

        public static void WriteToLog(Exception ex, string message)
        {
            logger.Information(ex, message);
        }
    }
}
