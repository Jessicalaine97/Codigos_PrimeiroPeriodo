internal class Program
{
    private static void Main(string[] args)
    {
    double valor=0, menor=0;

    Console.WriteLine("Digite o primeiro valor:");
    valor=Convert.ToDouble(Console.ReadLine());

    menor=valor;

    while (valor != 0)
    {
        Console.WriteLine("Digite o próximo valor (0 para sair):");
        valor=Convert.ToDouble(Console.ReadLine());

        if(valor < menor && valor != 0)
        {
            menor=valor;
        }
    }

    Console.WriteLine("O menor valor do conjunto informado é {0}.", menor);

    Console.ReadKey();
    }
   
}