internal class Program
{
    const int TAM = 10;
    static void GeraMatriz(double[] vet1, double[] vet2, double[] vet3)
    {
        double[,] mat = new double[TAM, 3];

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            mat[i, 0] = vet1[i];
        }

        for (int j = 0; j < mat.GetLength(0); j++)
        {
            mat[j, 1] = vet2[j];
        }

        for (int k = 0; k < mat.GetLength(0); k++)
        {
            mat[k, 2] = vet3[k];
        }

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("  {0} ", mat[i, j]);
            }
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        double[] vet1 = new double[TAM];
        double[] vet2 = new double[TAM];
        double[] vet3 = new double[TAM];

        Console.WriteLine("Entre com os dados do vetor 1: ");

        for (int i = 0; i < vet1.Length; i++)
        {
            Console.Write("  {0}/{1}: ", i + 1, TAM);
            vet1[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("\nEntre com os dados do vetor 2: ");

        for (int i = 0; i < vet2.Length; i++)
        {
            Console.Write("  {0}/{1}: ", i + 1, TAM);
            vet2[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("\nEntre com os dados do vetor 3: ");

        for (int i = 0; i < vet3.Length; i++)
        {
            Console.Write("  {0}/{1}: ", i + 1, TAM);
            vet3[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("\nImpressão da Matriz 10x3 que une os 3 vetores informados:");

        GeraMatriz(vet1, vet2, vet3);

        Console.ReadKey();
    }
}
