internal class Program
{
    const int TAM = 5;
    private static void Main(string[] args)
    {
        int i, j;
        double[,] matriz = new double[TAM, TAM];
        double soma = 0;

        Console.WriteLine("Entre com os elementos da matriz:");

        for (i = 0; i < matriz.GetLength(0); i++)
        {
            for (j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write("  ({0}, {1})= ", i + 1, j + 1);
                matriz[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        for (i = 0, j = 4; i < 5; i++, j--)
        {
            if (matriz[i, j] > 0)
            {
                soma += matriz[i, j];
            }
        }

        Console.WriteLine("Soma dos números positivos pertencentes a diagonal secundária da matriz: {0:N2}", soma);

        Console.ReadKey();
    }
}