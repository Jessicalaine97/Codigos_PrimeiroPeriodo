internal class Program
{
    const int TAM = 2;

    static int EncontraMaior(int[,] mat)
    {
        int maiorValor = 0;
        maiorValor = mat[0, 0];

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if (mat[i, j] > maiorValor)
                {
                    maiorValor = mat[i, j];
                }
            }
        }
        return maiorValor;
    }
    static int EncontraMenor(int[,] mat)
    {
        int menorValor = 0;
        menorValor = mat[0, 0];

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if (mat[i, j] < menorValor)
                {
                    menorValor = mat[i, j];
                }
            }
        }
        return menorValor;
    }
    private static void Main(string[] args)
    {
        int[,] mat = new int[TAM, TAM];
        int maiorValor = 0, menorValor = 0;

        Console.WriteLine("Entre com os dados da matriz: ");

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("  ({0}, {1}): ", i, j);
                mat[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        maiorValor = EncontraMaior(mat);
        menorValor = EncontraMenor(mat);

        Console.WriteLine("\nO maior valor da matriz é {0} e o menor é {1}.", maiorValor, menorValor);

        Console.ReadKey();
    }
}
