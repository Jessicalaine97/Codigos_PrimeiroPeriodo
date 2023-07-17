internal class Program
{
    private static void Main(string[] args)
    {
    double grausCelsius=0;
    int i;

    Console.WriteLine("Tabela de graus centígrados em função de graus Fahrenheit:");
    Console.WriteLine("Graus Celsius    |  Graus Fahrenheit ");

    for(i=50; i<=150; i++)
    {
        grausCelsius=0.556*(i-32);
        Console.WriteLine("|    {0:N4}     |        {1}     |", grausCelsius, i);
    }
    Console.ReadKey();
    }
}