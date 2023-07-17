using System;
using System.Text;
internal class Program
{
    const int TAM = 4;
    private static void Main(string[] args)
    {
        Ponto[] pontos = new Ponto[TAM];
        double dist1=0, dist2=0, dist3=0, dist4=0;

        for (int i = 0; i < pontos.Length; i++)
        {
            pontos[i] = new Ponto();

            Console.WriteLine("Ponto {0}/{1}:", i + 1, pontos.Length);

            Console.Write("  X (m): ");
            pontos[i].ValorX = Convert.ToInt32(Console.ReadLine());
            Console.Write("  Y (m): ");
            pontos[i].ValorY = Convert.ToInt32(Console.ReadLine());
        }

        dist1 = Math.Sqrt(Math.Pow(pontos[0].ValorX-pontos[1].ValorX,2)+Math.Pow(pontos[0].ValorY-pontos[1].ValorY, 2));
        dist2 = Math.Sqrt(Math.Pow(pontos[1].ValorX-pontos[2].ValorX,2)+Math.Pow(pontos[1].ValorY-pontos[2].ValorY, 2));
        dist3 = Math.Sqrt(Math.Pow(pontos[2].ValorX-pontos[3].ValorX,2)+Math.Pow(pontos[2].ValorY-pontos[3].ValorY, 2));
        dist4 = Math.Sqrt(Math.Pow(pontos[3].ValorX-pontos[1].ValorX,2)+Math.Pow(pontos[3].ValorY-pontos[1].ValorY, 2));

        Console.WriteLine("Distância entre os dois pontos: {0}m", distTotal);

        Console.ReadKey();
    }
}