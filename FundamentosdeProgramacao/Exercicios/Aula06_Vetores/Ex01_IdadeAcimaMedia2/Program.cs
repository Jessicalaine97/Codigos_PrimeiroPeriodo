internal class Program
{
    private static void Main(string[] args)
    {
        int[] idade = new int[10];
        double soma=0, media=0;
        int i, cont=0;

        Console.WriteLine("Informe as idades:");

        for (i=0; i<idade.Length; i++)
        {
            Console.Write("  Idade {0} de {1}:", i+1, idade.Length);
            idade[i]=Convert.ToInt32(Console.ReadLine());
        }

        for (i=0; i<idade.Length; i++)
        {
            soma+=idade[i];
        }

        media=soma/idade.Length;

        for(i=0; i<idade.Length ; i++)
        {
            if(idade[i] > media)
            {
                cont++;
            }
        }

        Console.WriteLine("\nIdades informadas:");

        for (i=0; i<idade.Length; i++)
        {
            Console.Write("  {0}, na posição {1}.", idade[i], i);
        }

        Console.WriteLine("A quantidade de idades superiores a média é: {0}.", cont);

        Console.ReadKey();
    }
}
