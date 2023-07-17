internal class Program
{
    static void MultiplicaVetorMatriz(int[,] mat, int[] vet)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j <mat.GetLength(1); j++)
            {
                Console.Write("  {0}", vet[i]*mat[i, j]);
            }
            Console.WriteLine();
        }
    }
    const int TAM = 2;
    private static void Main(string[] args)
    {
        int[,] mat = new int[TAM, TAM];
        int[] vet = new int[TAM];

        Console.WriteLine("Entre com os dados do vetor:");

        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write("  {0}/{1}: ", i, TAM);
            vet[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Entre com os dados da matriz:");

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("  ({0},{1}): ", i, j);
                mat[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Impressão do vetor multiplicado pela matriz:");

        MultiplicaVetorMatriz(mat, vet);

        Console.ReadKey();
    }
}
