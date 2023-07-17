internal class Program
{
    const int TAM = 2;

    static void MultiplicaMatrizes(int[,] mat1, int[,] mat2)
    {
        for (int i = 0; i < mat1.GetLength(0); i++)
        {
            for (int j = 0; j < mat1.GetLength(1); j++)
            {
                Console.Write("  {0}", mat1[i, j] * mat2[i, j]);
            }
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        int[,] mat1 = new int[TAM, TAM];
        int[,] mat2 = new int[TAM, TAM];

        Console.WriteLine("Entre com os dados da Matriz 1:");

        for (int i = 0; i < mat1.GetLength(0); i++)
        {
            for (int j = 0; j < mat1.GetLength(1); j++)
            {
                Console.Write("  ({0},{1}): ", i, j);
                mat1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nEntre com os dados da Matriz 2:");

        for (int i = 0; i < mat2.GetLength(0); i++)
        {
            for (int j = 0; j < mat2.GetLength(1); j++)
            {
                Console.Write("  ({0},{1}): ", i, j);
                mat2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nImpressão da multiplicado da Matriz 1 pela 2:");

        MultiplicaMatrizes(mat1, mat2);

        Console.ReadKey();
    }
}
