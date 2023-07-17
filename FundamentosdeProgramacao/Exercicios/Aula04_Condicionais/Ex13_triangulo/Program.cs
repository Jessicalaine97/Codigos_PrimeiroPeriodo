internal class Program
{
    private static void Main(string[] args)
    {
        double lado1, lado2, lado3;

        lado1 = LerLado("lado1");
        lado2 = LerLado("lado2");
        lado3 = LerLado("lado3");

        if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
            Console.WriteLine("Os valores {0}, {1} e {2} (m) formam um triângulo!", lado1, lado2, lado3);
        else
            Console.WriteLine("Os valores {0}, {1} e {2} (m) não formam um triângulo!", lado1, lado2, lado3);

        Console.ReadKey();
    }
    static double LerLado(string texto)
    {
        Console.WriteLine("Digite o valor do {0} (m).", texto);
        return Convert.ToDouble(Console.ReadLine());
    }
}