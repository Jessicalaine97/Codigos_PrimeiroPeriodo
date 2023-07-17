internal class Program
{
    const int TAM = 5;
    private static void Main(string[] args)
    {
        double[,] matriz = new double[TAM, TAM];
        double soma = 0;

        Console.WriteLine("Entre com os dados da matriz:");

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write("  ({0}, {1}): ", i + 1, j + 1);
                matriz[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        for (int i = 0, j = TAM-1; i < TAM; i++, j--)
        {
            if (matriz[i, j] > 0)
            {
                soma += matriz[i, j];
            }
        }

        Console.WriteLine("A soma dos elementos positivos da diagonal secundária da matriz informada vale: {0:N2}.", soma);

        Console.ReadKey();
    }
}