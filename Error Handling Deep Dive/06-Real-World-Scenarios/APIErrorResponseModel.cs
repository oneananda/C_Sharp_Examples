using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Error_Handling_Deep_Dive._06_Real_World_Scenarios
{
    public class APIErrorResponseModel
    {
        public string ErrorCode { get; set; }
        public string Message { get; set; }
        public string? Details { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }
    }

    class ApiSimulator
    {
        public static void Run()
        {
            try
            {
                // Simulating an API call failure
                throw new InvalidOperationException("Invalid API operation occurred");
            }
            catch (Exception ex)
            {
                var errorResponse = new APIErrorResponseModel
                {
                    ErrorCode = "API_500",
                    Message = "Internal Server Error",
                    Details = ex.Message
                };

                Console.WriteLine("API Error Response:");
                Console.WriteLine(errorResponse.ToString());
            }
        }
    }
}
