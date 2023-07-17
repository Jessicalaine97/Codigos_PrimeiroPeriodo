internal class Program
{
    private static void Main(string[] args)
    {
        double x1, x2, x3, y1, y2, y3, perimetro;

        x1= LerCoordenada("x1");
        y1= LerCoordenada("y1");
        x2= LerCoordenada("x2");
        y2= LerCoordenada("y2");
        x3= LerCoordenada("x3");
        y3= LerCoordenada("y3");

        perimetro=CalculaPerimetroTriangulo(x1, y1, x2, y2) + CalculaPerimetroTriangulo(x2, y2, x3, y3) + CalculaPerimetroTriangulo(x3, y3, x1, y1);

        Console.WriteLine("O perímetro do triângulo resulta em {0:N2}m.", perimetro);
        Console.ReadKey();
    }
    static double LerCoordenada (string texto)
    {
        Console.WriteLine("Digite o valor de {0} (m):", texto);
        
        return Convert.ToDouble(Console.ReadLine());
    }
     static double CalculaPerimetroTriangulo (double x1, double y1, double x2, double y2)
    {
        double distFinal;
    
        distFinal = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));

        return distFinal;
    }
}