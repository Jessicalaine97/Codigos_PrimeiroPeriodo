internal class Program
{
    private static void Main(string[] args)
    {
        double raio, volumeEsfera;
        Console.WriteLine("Digite o valor do raio da esfera (m):");
        raio=Convert.ToDouble(Console.ReadLine());

        volumeEsfera=CalculoVolumeEsfera(raio);

        Console.WriteLine("O volume da esfera de raio {0}m é de {1:N2} m^3.", raio, volumeEsfera);
        Console.ReadKey();
    }
    static double CalculoVolumeEsfera (double r)
    {
        double volume, PI=3.1415;
        volume=(4*PI*Math.Pow(r, 3))/3;
        return volume;
    }
}