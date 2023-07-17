internal class Program
{
    private static void Main(string[] args)
    {
        double posicaoInicial, posicaoFinal, velocidadeInicial, velocidadeFinal, aceleracao, tempo;

        Console.WriteLine("Digite a posição inicial (m):");
        posicaoInicial=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a velocidade inicial (m/s):");
        velocidadeInicial=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a aceleração (m/s^2):");
        aceleracao=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o tempo (s):");
        tempo=Convert.ToDouble(Console.ReadLine());

        posicaoFinal=CalculaPosicao(posicaoInicial, velocidadeInicial, tempo, aceleracao);
        velocidadeFinal=CalculaVelocidade(velocidadeInicial, aceleracao, tempo);

        Console.WriteLine("Para os dados informados, a posição final resultou em {0:N2}m e a velocidade em {1:N2}m/s.", posicaoFinal, velocidadeFinal);
        Console.ReadKey();
    }
    static double CalculaPosicao (double posicaoInicial, double velocidadeInicial, double tempo, double aceleracao)
    {
        double posicaoFinal;
        posicaoFinal=posicaoInicial+velocidadeInicial*tempo+(aceleracao*Math.Pow(tempo, 2))/2;
        return posicaoFinal;
    }
     static double CalculaVelocidade (double velocidadeInicial, double aceleracao, double tempo)
    {
        double velocidadeFinal;
        velocidadeFinal=velocidadeInicial+aceleracao*tempo;
        return velocidadeFinal;
    }
}