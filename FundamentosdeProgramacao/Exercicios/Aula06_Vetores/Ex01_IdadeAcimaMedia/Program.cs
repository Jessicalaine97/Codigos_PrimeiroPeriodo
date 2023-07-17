internal class Program
{
    private static void Main(string[] args)
    {
        int[] idade = new int[10];
        idade[0]=1; 
        idade[1]=2; 
        idade[2]=3; 
        idade[3]=4; 
        idade[4]=5; 
        idade[5]=6; 
        idade[6]=7; 
        idade[7]=8;
        idade[8]=9; 
        idade[9]=10;
        double soma=0, media=0;
        int cont=0;

        for (int i=0; i<10; i++)
        {
            soma+=idade[i];
        }

        media=soma/10;

        for(int i=0; i<10 ; i++)
        {
            if(idade[i] > media)
            {
                cont++;
            }
        }
        Console.WriteLine("A quantidade de idades superiores a média é: {0}.", cont);
        Console.ReadKey();
    }
}
