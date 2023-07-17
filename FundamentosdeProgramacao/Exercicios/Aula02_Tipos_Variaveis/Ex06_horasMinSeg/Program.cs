internal class Program
{
    private static void Main(string[] args)
    {
        int intervaloSegundos, segundos, minutos, horas;

        Console.WriteLine("Digite o intervalo de tempo desejado em segundos:");
        intervaloSegundos= Convert.ToInt32(Console.ReadLine());

        horas=intervaloSegundos/3600;
        minutos=(intervaloSegundos%3600)/60;
        segundos=(intervaloSegundos%3600)%60;

        Console.WriteLine("A conversão do intervalo de tempo informado de {0} segundo(s) equivale a: {1} hora(s), {2} minutos(s) e {3} segundo(s).", intervaloSegundos, horas, minutos, segundos);
        Console.ReadKey();
    }
}
