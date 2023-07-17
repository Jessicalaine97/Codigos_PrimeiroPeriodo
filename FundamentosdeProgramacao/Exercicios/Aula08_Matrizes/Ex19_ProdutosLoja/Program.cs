internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mat = new int[3, 5];
        int[] totalCadaProd=new int[3];
        //7 lojas com 5 tipos de produto 

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            Console.WriteLine("Loja {0}: \nQdd produtos:", i + 1);
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("    Tipo {0}: ", j + 1);
                mat[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                totalCadaProd[i]+=mat[i,j];
            }
        }

        Console.WriteLine("\nO total de cada produto nestas lojas:\n");

       
        for (int i = 0; i < totalCadaProd.Length; i++)
        {
            Console.WriteLine("Produto {0}: {1}", i+1, totalCadaProd[i]);
        }
        


        Console.ReadKey();
    }
}
