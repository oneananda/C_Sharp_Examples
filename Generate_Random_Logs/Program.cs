namespace Generate_Random_Logs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = 10000; // Change this to the desired number of lines
            string filePath = $"random_log.txt";
            GenerateLogFile(filePath, numberOfLines);
            Console.WriteLine($"Log file with {numberOfLines} lines generated at: {Path.GetFullPath(filePath)}");
        }

        static void GenerateLogFile(string filePath, int numberOfLines)
        {
            string[] logLevels = { "INFO", "DEBUG", "WARN", "ERROR", "FATAL" };
            string[] messages = {
            "User logged in",
            "File uploaded",
            "Database connection established",
            "Unexpected error occurred",
            "Memory usage is high",
            "Request timed out",
            "Cache cleared",
            "Configuration loaded",
            "Background job started",
            "API response received"
        };

            var rand = new Random();
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < numberOfLines; i++)
                {
                    string timestamp = DateTime.Now.AddSeconds(-rand.Next(0, 100000)).ToString("yyyy-MM-dd HH:mm:ss");
                    string level = logLevels[rand.Next(logLevels.Length)];
                    string message = messages[rand.Next(messages.Length)];

                    writer.WriteLine($"{timestamp} [{level}] - {message}");
                }
            }
        }
    }
}
