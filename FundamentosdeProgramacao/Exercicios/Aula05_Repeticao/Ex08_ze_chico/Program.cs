internal class Program
{
    private static void Main(string[] args)
    {
        double chico=1.50, ze=1.40;
        int cont=0;

        while (ze<=chico)
        {
            chico=1.50+0.02*cont;
            ze=1.40+0.03*cont;
            cont++;
        }

        Console.WriteLine("Serão necessários {0} anos para que Zé seja maior que Chico.", cont);

        Console.ReadKey();
    }
}