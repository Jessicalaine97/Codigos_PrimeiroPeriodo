internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa joao = new Pessoa();
        Pessoa maria = new Pessoa();
        double mediaAltura = 0, mediaPeso = 0;

        joao.altura = 1.90;
        joao.peso = 98;
        maria.altura = 1.50;
        maria.peso = 55;

        joao.altura = 1.78;
        maria.peso = 75;

        mediaAltura = (joao.altura + maria.altura) / 2;
        mediaPeso = (joao.peso + maria.peso) / 2;

        Console.WriteLine("João:");
        Console.WriteLine("  Peso: {0}kg\n  Altura: {1}m", joao.peso, joao.altura);

        Console.WriteLine("Maria:");
        Console.WriteLine("  Peso: {0}kg\n  Altura: {1}m", maria.peso, maria.altura);

        Console.WriteLine("\nMédias das alturas: {0:N2}m", mediaAltura);
        Console.WriteLine("Médias dos pesos: {0}m", mediaPeso);

        Console.ReadKey();
    }
}