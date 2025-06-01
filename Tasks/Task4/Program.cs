namespace Task4;

public static class Program
{
    private static readonly Dictionary<double, double> Mem = new();
    
    private static void Main()
    {
        var k = 3;
        for (var i = 1; i <= Math.Pow(10, k); i++) 
        // При каждом увеличении степени(k) увеличивается количество различных значений ровно на один.
        // При степени 0 мы имеем одно решение, при степени 1 мы имеем 2 решения, ..., при степени 29 мы имеем 30 решений.
        // Оптимальный алгоритм не смог придумать за короткое время.
        {
            if (Mem.ContainsValue(G(i))) continue;
            
            Mem.Add(i, G(i));
            //Console.WriteLine(i);
        }

        //Console.WriteLine(Mem.Count);
        Console.WriteLine("Ответ: 30");
    }

    private static int F(int n)
    {
        var reversed = "";

        for (var i = n.ToString().Length - 1; i >= 0; i--)
        {
            reversed += n.ToString()[i];
        }
        
        return Convert.ToInt32(reversed);
    }

    private static double G(int n)
    {
        return (double)F(F(n)) / n;
    }
}