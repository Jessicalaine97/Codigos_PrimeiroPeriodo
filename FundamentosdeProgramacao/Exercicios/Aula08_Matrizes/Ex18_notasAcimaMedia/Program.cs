internal class Program
{
    const int TAM = 10;
    static int ContaAprovados(double[,,] mat)
    {
        int qddAprovados = 0;
        double soma = 0, media = 0;

        for (int i = 0; i < TAM; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    soma += mat[i, j, k];
                }
                media = soma / 9;
                if (media >= 60)
                {
                    qddAprovados++;
                }
            }
        }

        return qddAprovados;
    }
    private static void Main(string[] args)
    {
        double[,,] mat = new double[TAM, 3, 3];
        int qddAprovados = 0;

        Console.WriteLine("Digite as 3 três notas de cada matéria considerando: \n1-Matemática\n2-História\n3-Geografia\n");

        // i(alunos), j(disciplina), k(prova)
        for (int i = 0; i < TAM; i++)
        {
            Console.WriteLine("Aluno {0}/10:", i + 1);
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("  - Disciplina {0}/3:", j + 1);
                for (int k = 0; k < 3; k++)
                {
                    Console.Write("     Nota TVC {0}/3: ", k + 1);
                    mat[i, j, k] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        qddAprovados = ContaAprovados(mat);

        Console.WriteLine("Houveram {0} aluno(s) aprovados,ou seja, que tiveram média aritmética > 60 nas 3 disciplinas.", qddAprovados);

        Console.ReadKey();
    }

}