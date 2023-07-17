internal class Program
{
    private static void Main(string[] args)
    {
        int num = 1;

        Console.WriteLine("Números pares no intervalo 1 a 100:");

        while (num <= 100)
        {
            if (num % 2 == 0)
            {
                Console.Write("{0}  ", num);
            }
            //num++
            num = num + 1;
        }
        Console.ReadKey();
    }
}
