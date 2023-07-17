internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Com 1 casa decimal:{0:N1}", 2.346728);
        Console.WriteLine("Com 2 casas decimais: {0:N2}", 2.346728);
        Console.WriteLine("Com 3 casas decimais: {0:N3}", 2.346728);
        Console.WriteLine("Com 5 casas decimais: {0:N5}", 2.346728);
        Console.ReadKey();
    }
}