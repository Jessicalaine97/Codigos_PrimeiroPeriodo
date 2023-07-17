internal class Program
{
    private static void Main(string[] args)
    {
        float Base, lado, altura, area, perimetro;

        Console.WriteLine("Digite o valor da base do triângulo em metros (m):");
        Base = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor do lado do triângulo em metros (m):");
        lado = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Agora digite a altura em metros (m):");
        altura = Convert.ToInt32(Console.ReadLine());

        perimetro=(Base+lado+altura);
        area=(Base*altura)/2;

        Console.WriteLine("O perímetro do triângulo é {0} metros.", perimetro);
        Console.WriteLine("A área do triângulo é {0} metros quadrados.", area);
        Console.ReadKey();
    }
}