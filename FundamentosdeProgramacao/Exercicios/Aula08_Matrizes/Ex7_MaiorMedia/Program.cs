internal class Program
{
    static void LeAluno(string[] nome, double[,] nota)
    {
        double somaMedias=0, somaNotas=0;
        //ou < vetNome.length
        for (int i = 0; i < 5; i++)
        {
            Console.Write("  Nome {0}/5: ", i + 1);
            nome[i] = Console.ReadLine();

            for (int j = 0; j < nota.GetLength(1); j++)
            {
                Console.Write("    Nota {0}/2: ", j + 1);
                nota[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }
        Console.Write("Aluno com notas acima da media:");
    }
    static int RetornaIndiceAlunoMaiorMedia(string[] nome, double[,] nota)
    {
        double maiorMedia = 0, soma = 0;
        int maiorIndice = 0;

        for (int i = 0; i < nota.GetLength(0); i++)
        {
            for (int j = 0; j < nota.GetLength(1); j++)
            {
                soma += nota[i, j];

            }
            if (soma / 2 > maiorMedia)
            {
                maiorMedia = soma / 2;
                maiorIndice = i;
            }
        }
        return maiorIndice;
    }
    private static void Main(string[] args)
    {
        double[,] nota = new double[5, 2];
        string[] nome = new string[5];
        int maiorIndice = 0;

        Console.WriteLine("Digite primeiramente o nome dos alunos e para cada nome, digite também suas duas notas:");

        LeAluno(nome, nota);

        maiorIndice = RetornaIndiceAlunoMaiorMedia(nome, nota);

        Console.WriteLine("\nO aluno com a maior média: {0}", nome[maiorIndice]);

        for (int j = 0; j < nota.GetLength(1); j++)
        {
            Console.Write("  Nota 1: {0}", nota[maiorIndice, j]);
        }

        Console.ReadKey();
    }
}
