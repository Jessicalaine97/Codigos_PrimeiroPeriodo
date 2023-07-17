internal class Program
{
    static void LeMatriz(double[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("  ({0},{1})=", i, j);
                mat[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
    static double MediaMatriz(double[,] mat)
    {
        double soma = 0, media = 0;

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                soma += mat[i, j];
            }
        }
        media = soma / 6;

        return media;
    }
    private static void Main(string[] args)
    {
        double[,] mat = new double[2, 3];
        double media = 0;

        Console.Write("Digite os elementos da matriz:\n");
        LeMatriz(mat);

        media = MediaMatriz(mat);

        Console.Write("\nA média dos valores da matriz informada é: {0:N2}", media);

        Console.ReadKey();
    }
}
