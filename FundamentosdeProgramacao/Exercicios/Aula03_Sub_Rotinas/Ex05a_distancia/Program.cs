internal class Program
{
    private static void Main(string[] args)
    {
        
    }
    static double CalculaDistancia (double x1, double y1, double x2, double y2)
    {
    double distX, distY, distFinal;
    distX=x2-x1;
    distY=y2-y1;
    distFinal=Math.Sqrt(Math.Pow(distX,2)+Math.Pow(distY,2));

    return distFinal;
    }
}