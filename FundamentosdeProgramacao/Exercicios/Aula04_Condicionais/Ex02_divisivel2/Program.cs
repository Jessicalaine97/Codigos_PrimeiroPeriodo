internal class Program
{
    private static void Main(string[] args)
    {
        double num;

        Console.WriteLine("Digite um número:");
        num=Convert.ToDouble(Console.ReadLine());

        if(num%2==0)
            Console.WriteLine("O número {0} é divisível por 2!", num);
        else
            Console.WriteLine("O número {0} não é divisível por 2!", num);

        Console.ReadKey();
    }
}