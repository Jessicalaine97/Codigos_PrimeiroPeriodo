internal class Program
{
    private static void Main(string[] args)
    {
        int num = 100;
        Console.WriteLine("Números de 100 até 1:");

        while (num >= 1)
        {
            Console.Write("{0}  ", num);
            //num--;
            num=num-1;
        }
        Console.ReadKey();
    }
}