internal class Program
{
    static void LeMatriz(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("  ({0}, {1}): ", i, j);
                mat[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    static void ImprimeElementosColuna(int[,] mat, int coluna)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            Console.WriteLine("  ({0}, {1}): {2}", i, coluna, mat[i, coluna]);
        }
    }
    const int TAM = 3;
    private static void Main(string[] args)
    {
        int[,] mat = new int[TAM, TAM];
        int coluna = 0;

        Console.WriteLine("Insira os elementos da matriz:");
        LeMatriz(mat);

        Console.Write("\nInsira o número da coluna desejada: ");
        coluna = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nImpressão da matriz na coluna {0}:", coluna);
        ImprimeElementosColuna(mat, coluna);

        Console.ReadKey();
    }
}
