internal class Program
{
    private static void Main(string[] args)
    {
        float grausCelsius, grausFahrenheit;
        
        Console.WriteLine("Digite a temperatura em °C:");
        grausCelsius=Convert.ToSingle(Console.ReadLine());
        grausFahrenheit=(9*grausCelsius)/5;
        Console.WriteLine("{0} graus Celsius (°C) equivale a {1} graus Fahrenheit (°F).", grausCelsius, grausFahrenheit);
        Console.ReadKey();
    }
}