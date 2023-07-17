internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mat = new int[2, 3];

        Console.WriteLine("Entre com os dados da matriz: ");

       for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("  ({0}, {1}): ", i, j);
                mat[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\n Impressão da Coluna 3:");

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            Console.WriteLine("  ({0}, {1}) = {2} ", i, 2, mat[i, 2]);
        }

        Console.ReadKey();
    }
}
