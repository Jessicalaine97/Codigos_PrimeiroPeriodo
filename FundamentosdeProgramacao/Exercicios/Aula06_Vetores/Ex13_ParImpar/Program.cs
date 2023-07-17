internal class Program
{
    static void LeValores(int[] vetorV)
    {

        Console.WriteLine("Digite os valores do vetor:");

        for (int i = 0; i < vetorV.Length; i++)
        {
            Console.WriteLine("  {0}/{1}: ", i + 1, vetorV.Length);
            vetorV[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    private static void Main(string[] args)
    {
        int[] vetorV = new int[5] {1, 2, 3, 4, 5};
        int[] vetorI = new int[5];
        int[] vetorP = new int[5];

        for (int i = 0; i < vetorV.Length; i++)
        {
            if (vetorV[i] % 2 == 0)
            {
                vetorP[i] = vetorV[i];
            }
            else
            {
                vetorI[i] = vetorV[i];
            }
        }

        Console.WriteLine("Impressão do Vetor V:");

        for (int i = 0; i < vetorV.Length; i++)
        {
            Console.WriteLine("  {0} na posição {1}", vetorV[i], i);
        }

        Console.WriteLine("\nImpressão do Vetor P:");

        for (int i = 0; i < vetorP.Length; i++)
        {
            Console.WriteLine("  {0} na posição {1}", vetorP[i], i);
        }

        Console.WriteLine("\nImpressão do Vetor I:");

        for (int i = 0; i < vetorI.Length; i++)
        {
            Console.WriteLine("  {0} na posição {1}", vetorI[i], i);
        }

        Console.ReadKey();
    }
}
