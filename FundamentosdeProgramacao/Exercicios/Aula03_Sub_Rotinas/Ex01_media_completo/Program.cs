internal class Program
{
    private static void Main(string[] args)
    {
        double valor1, valor2, valor3, mediaAritimetica;

        Console.WriteLine("Insira o primeiro valor real:");
        valor1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o segundo valor real:");
        valor2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o terceiro valor real:");
        valor3 = Convert.ToDouble(Console.ReadLine());

        mediaAritimetica = CalculaMediaAritimetica(valor1, valor2, valor3);

        Console.WriteLine("O cálculo da média aritmética dos valor reais {0}, {1} e {2} resultou em {3}.", valor1, valor2, valor2, mediaAritimetica);
        Console.ReadKey();
    }
    static double CalculaMediaAritimetica(double valor1, double valor2, double valor3)
    {
        double mediaAritmetica;
        mediaAritmetica = (valor1 + valor2 + valor3) / 3;
        return mediaAritmetica;
    }
}
