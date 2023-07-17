internal class Program
{
    private static void Main(string[] args)
    {
    int[] vetIdades = new int[2];

    Console.WriteLine("Digite as idades:");
    LeIdades(vetIdades);

    Console.WriteLine("\nAs idades informadas foram:");
    Imprime(vetIdades);

    Console.ReadKey();
    }
    static void LeIdades(int[] idades)
    {
        for(int i=0; i<idades.Length; i++)
        {
            Console.Write("  {0} de {1}: ", i, 2);
            idades[i]=Convert.ToInt32(Console.ReadLine());
        }
    }
    static void Imprime (int[] idades)
    {
        for(int i=0; i<idades.Length; i++)
        {
            Console.WriteLine("  {0} na posição {1}", idades[i], i);
        }
    }
}
