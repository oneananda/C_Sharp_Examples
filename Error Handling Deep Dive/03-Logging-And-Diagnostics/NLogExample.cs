using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._03_Logging_And_Diagnostics
{
    class NLogExample
    {
        // Create logger instance
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static void Run()
        {
            // Configure NLog programmatically (you can also use nlog.config)
            var config = new NLog.Config.LoggingConfiguration();

            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "nlog_log.txt" };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

            config.AddRule(NLog.LogLevel.Info, NLog.LogLevel.Fatal, logconsole);
            config.AddRule(NLog.LogLevel.Debug, NLog.LogLevel.Fatal, logfile);

            LogManager.Configuration = config;

            logger.Info("Application started");

            try
            {
                logger.Debug("Attempting risky operation...");
                string str = null;
                Console.WriteLine(str.Length); // null reference exception
            }
            catch (Exception ex)
            {
                logger.Error(ex, "An exception occurred");
            }
            finally
            {
                logger.Info("Application shutting down");
                LogManager.Shutdown();
            }
        }
    }
}
