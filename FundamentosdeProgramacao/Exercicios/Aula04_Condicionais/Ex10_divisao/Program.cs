internal class Program
{
    private static void Main(string[] args)
    {
        double num1, num2;

        Console.WriteLine("Digite um valor para o primeiro número:");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite um valor para o segundo número:");
        num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 != 0)
            Console.WriteLine("{0}/{1}={2:N4}.", num1, num2, num1 / num2);
        else
            Console.WriteLine("Operação inválida!");

        Console.ReadKey();
    }
}