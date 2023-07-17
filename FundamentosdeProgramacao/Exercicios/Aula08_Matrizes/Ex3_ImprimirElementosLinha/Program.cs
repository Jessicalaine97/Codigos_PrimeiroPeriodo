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
    static void ImprimeElementosLinha(int[,] mat, int linha)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.WriteLine("  ({0}, {1}): {2}", linha, j, mat[linha, j]);
        }
    }
    const int TAM = 3;
    private static void Main(string[] args)
    {
        int[,] mat = new int[TAM, TAM];
        int linha = 0;

        Console.WriteLine("Insira os elementos da matriz:");
        LeMatriz(mat);

        Console.Write("\nInsira o número da linha desejada: ");
        linha = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nImpressão da matriz na linha {0}:", linha);
        ImprimeElementosLinha(mat, linha);

        Console.ReadKey();
    }
}
