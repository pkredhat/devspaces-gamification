using Microsoft.AspNetCore.Mvc;
namespace ds_challenge_01.Controllers;

[ApiController]
[Route("[controller]")]
public class DateResource : ControllerBase
{
    [HttpGet("currentdate")]
    [Produces("text/plain")]
    public string GetCurrentDate()
    {
        // TODO: Return the String "Current Date=[2024-10-22]"
        // You should use out-of-the-box classes for working with dates.
        // IntelliSense has to work.
        return $"Current Date=[{DateTime.Now:yyyy-MM-dd}]";
    }

    [HttpPost("CalculateAndPrintStatistics")]
    [Produces("text/plain")]    
    public string CalculateAndPrintStatistics(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0) return "No data provided.";
        
        int sum = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }
        double average = (double)sum / numbers.Length;
        return "Average: " + average + " | " + "Maximum: " + max + " | " + "Minimum: " + min;
    }
}
