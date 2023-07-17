internal class Program
{
    private static void Main(string[] args)
    {
        double num1, num2;
        char operador;

        Console.WriteLine("Digite o valor do primeiro número:");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor do segundo número:");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o operador (+, -, / ou *):");
        operador = Convert.ToChar(Console.ReadLine());

        if (operador == '+')
            Console.WriteLine("{0}+{1}={2}.", num1, num2, num1 + num2);
        else if (operador == '-')
            Console.WriteLine("{0}-{1}={2}.", num1, num2, num1 - num2);
        else if (operador == '*')
            Console.WriteLine("{0}*{1}={2}.", num1, num2, num1 * num2);
        else if (operador == '/')
            Console.WriteLine("{0}/{1}={2}.", num1, num2, num1 / num2);
        else
            Console.WriteLine("Operação inválida!");

        Console.ReadKey();
    }
}