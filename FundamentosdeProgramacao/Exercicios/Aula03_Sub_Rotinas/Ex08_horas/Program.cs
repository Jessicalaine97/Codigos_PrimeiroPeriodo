internal class Program
{
    private static void Main(string[] args)
    {
    }
    static void ConverteTempo (double duracaoSegundos)
    {
    double horas, min, seg;
    
    seg=duracaoSegundos/60;
    min=(duracaoSegundos/60)/60;
    horas=(duracaoSegundos/60)%60;

    Console.WriteLine("A conversão de {0} segundos equivale a {1:N2}:{2:N2}:{3:N2}.",duracaoSegundos, horas, min, seg);
    }
}