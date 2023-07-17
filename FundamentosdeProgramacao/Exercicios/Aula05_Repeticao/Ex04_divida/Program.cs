internal class Program
{
    private static void Main(string[] args)
    {
        double divida = 1000, aplicacao = 1500;
        int cont=0;

        while (aplicacao < divida)
        {
            divida *=1.025;
            aplicacao *=1.04;
            cont++;
        }

        Console.WriteLine("Serão necessários {0} mese(s) para pagar a dívida.", cont);

        Console.ReadKey();
    }
}