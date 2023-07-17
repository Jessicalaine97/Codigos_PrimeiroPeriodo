internal class Program
{
    private static void Main(string[] args)
    {
        double x1, x2, x3, y1, y2, y3, perimetro;
        
        Console.WriteLine("Digite o valor de x1 (m):");
        x1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor de y1 (m):");
        y1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor de x2 (m):");
        x2=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor de y2 (m):");
        y2=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor de x3 (m):");
        x3=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor de y3 (m):"); 
        y3=Convert.ToDouble(Console.ReadLine());

        perimetro=CalculaPerimetroTriangulo(x1, y1, x2, y2) + CalculaPerimetroTriangulo(x2, y2, x3, y3) + CalculaPerimetroTriangulo(x3, y3, x1, y1);

        Console.WriteLine("O perímetro do triângulo resulta em {0:N2}m.", perimetro);
        Console.ReadKey();
    }
     static double CalculaPerimetroTriangulo (double x1, double y1, double x2, double y2)
    {
        double distFinal;
    
        distFinal = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
    
        return distFinal;
    }
}