internal class Program
{
    private static void Main(string[] args)
    {
    double num, fat=1, resultado=1;
    int i;

    Console.WriteLine("Digite o valor do número:");
    num=Convert.ToDouble(Console.ReadLine());

    for (i=1; i<=num; i++)
    {
        fat=i;
        resultado*=fat;
    }
    
    Console.WriteLine("Fatorial de {0} é {1:N1}.", num, resultado);
    Console.ReadKey();
    }
}