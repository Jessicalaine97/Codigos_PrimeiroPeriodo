internal class Program
{
const int NUM_ALUNOS = 50;
    private static void Main(string[] args)
    {
        double[] notas= new double[NUM_ALUNOS];
        double soma=0, media=0;
        int i, cont=0;

        for (i=0; i<NUM_ALUNOS; i++)
        {
            Console.WriteLine("Digite o valor da nota {0}/{1}:", i+1, NUM_ALUNOS);
            notas[i]=Convert.ToDouble(Console.ReadLine());
            soma+=notas[i];
        }

        media=soma/NUM_ALUNOS;

        for(i=0; i<NUM_ALUNOS; i++)
        {
            if(notas[i] >= media)
            {
                cont++;
            }
        }
        Console.WriteLine("A quantidade de aprovados é: {0}.", cont);
        Console.ReadKey();
    }
}
