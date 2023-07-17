internal class Program
{
    static void LerMatriz(int escolha, int[,] mat1, int[,] mat2)
    {
        if (escolha == 1 || escolha == 2 || escolha == 4)
        {
            Console.WriteLine("\nEntre com os dados da matriz 1: ");

            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    Console.Write("  ({0}, {1}): ", i, j);
                    mat1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nEntre com os dados da matriz 2: ");

            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    Console.Write("  ({0}, {1}): ", i, j);
                    mat2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        else if (escolha == 3)
        {
            Console.WriteLine("\nEntre com os dados da matriz 1: ");

            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    Console.Write("  ({0}, {1}): ", i, j);
                    mat1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        else if (escolha == 5)
            Console.Write("Fim do programa!");

        else
            Console.Write("Opção inválida!");
    }
    static void FazerOperacoes(int escolha, int[,] mat1, int[,] mat2)
    {
        if (escolha == 1)
        {
            Console.WriteLine("\nSoma das duas matrizes:");

            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    Console.Write("  {0}", mat1[i, j] + mat2[i, j]);
                }
            Console.WriteLine();
            }
        }
        else if (escolha == 2)
        {
            Console.WriteLine("\nDiferença das duas matrizes:");

            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    Console.Write("  {0}", mat1[i, j] - mat2[i, j]);
                }
            Console.WriteLine();
            }

        }
        else if (escolha == 3)
        {
            Console.WriteLine("\nTransposição das duas matrizes:");

            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    Console.Write("  {0}", mat1[i, j] == mat2[j, i]);
                }
            Console.WriteLine();
            }
        }
        else if (escolha == 4)
        {
            Console.WriteLine("\nProduto das duas matrizes:");

            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    Console.Write("  {0}", mat1[i, j] * mat2[i, j]);
                }
            Console.WriteLine();
            }
        }

    }
    private static void Main(string[] args)
    {
        int escolha = 0;
        int[,] mat1 = new int[3, 3];
        int[,] mat2 = new int[3, 3];

        Console.WriteLine("Escolha uma opção de cálculo para matrizes:\n1) Soma \n2) Diferença \n3) Transposta \n4) Produto \n5) Sair");
        Console.Write(" \nOpção desejada: ");
        escolha = Convert.ToInt32(Console.ReadLine());

        LerMatriz(escolha, mat1, mat2);

        FazerOperacoes(escolha, mat1, mat2);

        Console.ReadKey();
    }
}
