internal class Program
{
    private static void Main(string[] args)
    {
        float altura, largura, comprimento;

        Console.WriteLine("Qual a altura da caixa retangular (m) ?");
        altura=Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Qual a largura (m) ?");
        largura=Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("E o comprimento (m) ?");
        comprimento=Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("O volume da caixa retangular é de {0} metro(s) cúbico(s).", altura*largura*comprimento);
        Console.ReadKey();
    }
}