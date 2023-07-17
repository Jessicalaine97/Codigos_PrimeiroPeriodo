internal class Program
{
    private static void Main(string[] args)
    {
        double num1, num2;

        Console.WriteLine("Digite o valor do primeiro número:");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor do segundo número:");
        num2 = Convert.ToDouble(Console.ReadLine());

        if (num1 > num2)
            Console.WriteLine("{0} é maior que {1}.", num1, num2);
        else if (num1 == num2)
            Console.WriteLine("{0} é igual a {1}.", num1, num2);
        else
            Console.WriteLine("{0} é menor que {1}.", num1, num2);

        Console.ReadKey();
    }
}