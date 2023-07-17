internal class Program
{
    static string Aspas(string texto)
    {
        return "\"" + texto + "\"";
    }
    private static void Main(string[] args)
    {
        string texto = "jessica";

        Console.Write("\nImpressão da string entre aspas: {0}", Aspas(texto));

        Console.ReadKey();
    }
}
