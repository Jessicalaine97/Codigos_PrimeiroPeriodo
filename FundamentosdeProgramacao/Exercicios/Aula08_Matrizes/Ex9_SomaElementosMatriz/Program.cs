internal class Program
{
    const int TAM = 2;
    static double SomaElementosMatriz(double[,] mat)
    {
        double soma=0;

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                soma+=mat[i,j];
            }
        }

        return soma;
    }
    private static void Main(string[] args)
    {
        double[,] mat = new double[TAM, TAM];
        double soma=0;

        Console.WriteLine("Entre com os dados da matriz:");

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("  ({0},{1}): ", i, j);
                mat[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        soma=SomaElementosMatriz(mat);

        Console.WriteLine("A soma dos elementos da matriz é: {0:N2}.", soma);

        Console.ReadKey();
    }
}
