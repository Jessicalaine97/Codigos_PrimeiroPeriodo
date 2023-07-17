internal class Program
{
    static void DivideMatriz(int[,] mat)
    {
        Console.WriteLine("\nImpressão da divisão 1 (até a linha 3):");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("  ({0}, {1}) = {2} ", i, j, mat[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nImpressão da divisão 2 (da linha 3 até a 6):");

        for (int i = 3; i < 6; i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("  ({0}, {1}) = {2} ", i, j, mat[i, j]);
            }
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        int[,] mat = new int[6, 3];

        Console.WriteLine("Entre com os dados da matriz: ");

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("  ({0}, {1}): ", i, j);
                mat[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        DivideMatriz(mat);

        Console.ReadKey();
    }
}
