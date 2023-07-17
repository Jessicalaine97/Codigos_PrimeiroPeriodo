internal class Program
{
    private static void Main(string[] args)
    {
        int matricula=0;
        double nota1=0, nota2=0, nota3=0, media=0;

        Console.WriteLine("Digite a matrícula do aluno:");
        matricula=Convert.ToInt32(Console.ReadLine());

        while (nota1 >= 0 || nota2 >= 0 || nota3 >= 0)
        {
            Console.WriteLine("Digite a primeira nota:");
            nota1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            nota2=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            nota3=Convert.ToDouble(Console.ReadLine());
                
                if(nota1 > nota2 && nota1 > nota3)
                    media=(nota1*4+nota2*3+nota3*3)/10;
                
                else if (nota2 > nota1 && nota2 > nota3)
                    media=(nota2*4+nota1*3+nota3*3)/10;
                
                else if (nota3 > nota1 && nota3 > nota2)
                    media=(nota3*4+nota1*3+nota2*3)/10;
        }
        
        if (media>=5) 
            Console.WriteLine("Aluno: {0} - APROVADO! - Média: {1}", matricula, media);
        else
            Console.WriteLine("Aluno: {0} - REPROVADO! - Média: {1}", matricula, media);

        Console.ReadKey();
    }
   
}