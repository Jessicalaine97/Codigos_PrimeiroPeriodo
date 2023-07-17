internal class Program
{
    private static void Main(string[] args)
    {
        double So, S, Vo, V, a, t;

        So=LeValores("So");
        Vo=LeValores("Vo");
        a=LeValores("a");
        t=LeValores("t");

        S=CalculaPosicao(So, Vo, t, a);
        V=CalculaVelocidade(Vo, a, t);

        Console.WriteLine("Para os dados informados, a posição final resultou em {0:N2}m e a velocidade em {1:N2}m/s.", S, V);
        Console.ReadKey();
    }
    static double LeValores (string texto)
    {
        Console.WriteLine("Digite o valor de {0}:", texto);
        return Convert.ToDouble(Console.ReadLine());
    }
    static double CalculaPosicao (double So, double Vo, double t, double a)
    {
        double S;
        S=So+Vo*t+(a*Math.Pow(t, 2))/2;
        return S;
    }
     static double CalculaVelocidade (double Vo, double a, double t)
    {
        double V;
        V=Vo+a*t;
        return V;
    }
}