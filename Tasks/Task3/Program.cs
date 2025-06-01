using System.Numerics;

namespace Task3;

internal static class Program
{
    public static void Main()
    {
        var oddValues = new List<BigInteger>();
        BigInteger a = 1;
        BigInteger b = 3;

        if (a % 2 == 1) oddValues.Add(a);
        if (b % 2 == 1) oddValues.Add(b);

        while (oddValues.Count < 40)
        {
            var next = 5 * b + a;
            a = b;
            b = next;
                
            if (next % 2 == 1)
            {
                oddValues.Add(next);
            }
        }

        Console.WriteLine(oddValues[39]);
    }
}