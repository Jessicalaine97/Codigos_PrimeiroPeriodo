internal class Program
{
    static int ContaCaracter(string[,] mat)
    {
        int contaQddA=0;

         for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if(mat[i, j]=="a")
                {
                    contaQddA++;
                }
            }
        }
        return contaQddA;
    }

    private static void Main(string[] args)
    {
        string[,] mat = new string[2, 3];
        int contaQddA=0;

        Console.WriteLine("Entre com os dados da matriz: ");

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("  ({0}, {1}): ", i, j);
                mat[i, j] = Console.ReadLine();
            }
        }

        contaQddA=ContaCaracter(mat);

        Console.WriteLine("\nExistem {0} letras 'a' na matriz informada!", contaQddA);

        Console.ReadKey();
    }
}
