internal class Program
{
    static void LeVetor(int[] idade)
    {
        int i;

        for (i = 0; i < idade.Length; i++)
        {
            Console.Write("  {0} de {1}:", i + 1, idade.Length);
            idade[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static int SomaVetor(int[] idade)
    {
        int i, soma = 0;

        for (i = 0; i < idade.Length; i++)
        {
            soma += idade[i];
        }
        return soma;
    }

    static int ContarValoresAcimaMedia(int[] idade, double media)
    {
        int i, cont = 0;

        for (i = 0; i < idade.Length; i++)
        {
            if (idade[i] > media)
            {
                cont++;
            }
        }
        return cont;
    }
    private static void Main(string[] args)
    {
        int[] idade = new int[10];
        double soma, media = 0;
        int qddAcimaMedia;

        Console.WriteLine("Informe as idades:");

        LeVetor(idade);

        soma = SomaVetor(idade);

        media = soma / idade.Length;

        qddAcimaMedia = ContarValoresAcimaMedia(idade, media);

        Console.WriteLine("A quantidade de idades superiores a média é: {0}.", qddAcimaMedia);

        Console.ReadKey();
    }
}
