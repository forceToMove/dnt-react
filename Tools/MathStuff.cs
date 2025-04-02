using System.Diagnostics;
using System.Numerics;

namespace Pollful.Tools;


public static class MathStuff 
{
    public static string Factorial(int n)
    {

        Stopwatch stopwatch = Stopwatch.StartNew();
        BigInteger result = 1;

        while (n > 0)
        {
            result *= n;
            n--;
            
        }
        stopwatch.Stop();

        Console.WriteLine($"Elapsed time {stopwatch.ElapsedMilliseconds}");
        
        return result.ToString();
    }
}