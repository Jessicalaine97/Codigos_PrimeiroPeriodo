internal class Program
{
    private static void Main(string[] args)
    {
        double num;

        Console.WriteLine("Digite um número:");
        num = Convert.ToDouble(Console.ReadLine());

        if (num % 2 == 0 && num % 3 == 0)
            Console.WriteLine("O número {0} é divisível por 2 e 3!", num);
        else
        //importante colocar OU
            Console.WriteLine("O número {0} não é divisível por 2 ou 3!", num);

        Console.ReadKey();
    }
}