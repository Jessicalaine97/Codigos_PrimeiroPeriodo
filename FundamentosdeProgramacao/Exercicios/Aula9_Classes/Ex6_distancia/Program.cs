using System;
using System.Text;
internal class Program
{
    const int TAM = 2;
    private static void Main(string[] args)
    {
        Ponto[] pontos = new Ponto[TAM];
        double distX = 0, distY = 0, distTotal = 0;

        for (int i = 0; i < pontos.Length; i++)
        {
            pontos[i] = new Ponto();

            Console.WriteLine("Ponto {0}/{1}:", i + 1, pontos.Length);

            Console.Write("  X (m): ");
            pontos[i].ValorX = Convert.ToInt32(Console.ReadLine());
            Console.Write("  Y (m): ");
            pontos[i].ValorY = Convert.ToInt32(Console.ReadLine());
        }

        distX = pontos[1].ValorX - pontos[0].ValorX;
        distY = pontos[1].ValorY - pontos[0].ValorY;
        distTotal = Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2));

        Console.WriteLine("Distância entre os dois pontos: {0}m", distTotal);

        Console.ReadKey();
    }
}