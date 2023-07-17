internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c, delta, x1, x2;

        a=LeValores("a");
        b=LeValores("b");
        c=LeValores("c");

        delta=Math.Pow(b,2)-(4*a*c);

        if (delta<0)
            Console.WriteLine("Não há solução real!");
        else
        {
            x1=(-b+Math.Sqrt(delta))/(2*a);
            x2=(-b-Math.Sqrt(delta))/(2*a);
            Console.WriteLine("As raízes da equação fornecida são {0} e {1}.", x1, x2);
        }
        Console.ReadKey();
    }

    static double LeValores (string texto)
    {
        Console.WriteLine("Digite o valor do coeficiente {0}:", texto);
        return Convert.ToDouble(Console.ReadLine());
    }
}