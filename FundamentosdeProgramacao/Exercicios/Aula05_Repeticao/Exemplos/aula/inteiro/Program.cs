internal class Program
{
    private static void Main(string[] args)
    {
        double media;
        int num;

        Console.WriteLine("Digite um valor inteiro:");
        num = Convert.ToInt32(Console.ReadLine());

        media = mediaInteiros(num);

        Console.WriteLine("O valor da média dos valores informados é: {0:N2}.", media);
        Console.ReadKey();
    }
    static double mediaInteiros(int num)
    {
        double soma = 0, media = 0, valor;
        int i;

        for (i = 1; i <= num; i++)
        {
            Console.WriteLine("Digite o {0}° valor:", i);
            valor = Convert.ToInt32(Console.ReadLine());
            soma += valor;
        }
        media = soma / num;
        return media;
    }
}