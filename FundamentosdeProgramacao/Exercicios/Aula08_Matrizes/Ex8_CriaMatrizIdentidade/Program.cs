internal class Program
{
    const int TAM = 5;
    static void CriaIdentidade(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if (i == j)
                {
                    mat[i, j] = 1;
                }
                else
                {
                    mat[i, j] = 0;
                }
            }
        }
        Console.WriteLine("\nImpressão da Matriz Identidade:");

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("{0} ", mat[i, j]);
            }
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        int[,] mat = new int[TAM, TAM];

        CriaIdentidade(mat);

        Console.ReadKey();
    }
}
