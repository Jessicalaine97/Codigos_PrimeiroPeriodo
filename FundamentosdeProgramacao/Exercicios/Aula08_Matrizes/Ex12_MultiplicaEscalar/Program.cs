internal class Program
{
    static void MultiplicaMatrizEscalar(int[,] mat, int escalar)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                mat[i,j]*=escalar;
            }
        }
    }
    static void ImprimeMatriz(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("  {0}", mat[i,j]);
            }
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        int[,] mat = new int[3, 4];
        int escalar = 0;

        Console.WriteLine("Entre com os dados da matriz: ");

       for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("  ({0}, {1}): ", i, j);
                mat[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nEntre com o valor do escalar: ");
        escalar=Convert.ToInt32(Console.ReadLine());

        MultiplicaMatrizEscalar(mat, escalar);

        Console.WriteLine("\nImpressão da matriz multiplicada pelo escalar: ");
        ImprimeMatriz(mat);

        Console.ReadKey();
    }
}
