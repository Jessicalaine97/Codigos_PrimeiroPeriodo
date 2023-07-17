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
    static void ImprimeDiagonalSecundaria(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if (i + j == mat.GetLength(0) - 1)
                {
                    Console.WriteLine("  ({0}, {1}): {2}", i, j, mat[i, j]);
                }
            }
        }
    }
    const int TAM = 3;
    private static void Main(string[] args)
    {
        int[,] mat = new int[TAM, TAM];

        Console.WriteLine("Insira os elementos da matriz:");
        LeMatriz(mat);

        Console.WriteLine("\nImpressão da diagonal secundária da matriz:");
        ImprimeDiagonalSecundaria(mat);

        Console.ReadKey();
    }
}
