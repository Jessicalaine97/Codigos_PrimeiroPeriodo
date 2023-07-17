internal class Program
{
    private static void Main(string[] args)
    {
    int n, i;
    double e=0, fat=1;

    Console.WriteLine("Digite um número inteiro e positivo:");
    n=Convert.ToInt32(Console.ReadLine());

    for(i=1; i<=n; i++)
    {
        fat*=i;
        e+=1/fat;
    }

    Console.WriteLine("O valor da expressão é: {0:N4}.", e+1);
    Console.ReadKey();
    }
   
}