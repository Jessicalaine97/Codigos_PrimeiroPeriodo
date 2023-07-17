internal class Program
{
    private static void Main(string[] args)
    {
    }
    
    // só procedimento = não retorna -> void ; se pedir só ele imprime dentro dele msm !!!
    // só isso é o exercicio (não pediu main)
    static void CalculaMediaAritimetica (double valor1, double valor2, double valor3)
    {
    double mediaAritmetica;
    mediaAritmetica=(valor1+valor2+valor3)/3;
    Console.WriteLine("A média é: {0}", mediaAritmetica);
    }
}
