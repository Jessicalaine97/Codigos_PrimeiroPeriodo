internal class Program
{
    private static void Main(string[] args)
    {
        int exp, div;
        double s=0;

        //nao tem necessidade de conferir o div>=2
        for (exp=1, div=50; exp<=25 && div>=2; exp++, div-=2)
        {
            s += Math.Pow(2,exp)/div;
        }

        Console.WriteLine("O valor de S será de {0:N2}.", s);

        Console.ReadKey();
    }
}