internal class Program
{
    private static void Main(string[] args)
    {
        int num = 2;
        Console.WriteLine("Números pares no intervalo 0 a 100:");

        while (num <= 100)
        {
            Console.Write("{0}  ", num);
            //num+=2
            //ctrl+c para looping
            num = num + 2;
        }
        Console.ReadKey();
    }
}
