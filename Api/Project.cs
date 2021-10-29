using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

public class Starship
{
    [Range(1, 99, ErrorMessage = "Number invalid.")]
    public int num1 { get; set; }
    
    [Range(1, 99, ErrorMessage = "Number invalid.")]
    public int num2 { get; set; }
    
    [Range(1, 99, ErrorMessage = "Number invalid.")]
    public int num3 { get; set; }
    
    avg = (num1 + num2 + num3) / 3;
    
    
}
{

     
    public static class Project
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,avg;
 
            Console.Write("Enter 1st number :");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number :");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number :");
            number3 = Convert.ToInt32(Console.ReadLine());
 
            avg = (num1 + num2 + num3) / 3;
 
            Console.Write("Avarage of three numbers is {0}",avarage);
 
            Console.ReadKey();
        }
    }
 
    public static class ThreeNumbersAverage
    {
        private static string GetSummary(int temp)
        {
            var summary = "Mild";

            if (temp >= 32)
            {
                summary = "Hot";
            }
            else if (temp <= 16 && temp > 0)
            {
                summary = "Cold";
            }
            else if (temp <= 0)
            {
                summary = "Freezing";
            }

            return summary;
        }

        [FunctionName("WeatherForecast")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            var randomNumber = new Random();
            var temp = 0;

            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = temp = randomNumber.Next(-20, 55),
                Summary = GetSummary(temp)
            }).ToArray();

            return new OkObjectResult(result);
        }
    }
}
