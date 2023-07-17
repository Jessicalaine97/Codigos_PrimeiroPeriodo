internal class Program
{
    static int CalculaAcimaMedia(int[] idade)
    {
        double soma=0, media=0;
        int cont=0;

        for (int i=0; i<10; i++)
        {
            soma+=idade[i];
        }

        media=soma/10;

        for(int i=0; i<10 ; i++)
        {
            if(idade[i] > media)
            {
                cont++;
            }
        }

        return cont;
    }
    private static void Main(string[] args)
    {
        int[] idade = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int qddAcimaMedia=0;

        qddAcimaMedia=CalculaAcimaMedia(idade);

        Console.WriteLine("A quantidade de idades superiores a média é: {0}.", qddAcimaMedia);
        Console.ReadKey();
    }
}
