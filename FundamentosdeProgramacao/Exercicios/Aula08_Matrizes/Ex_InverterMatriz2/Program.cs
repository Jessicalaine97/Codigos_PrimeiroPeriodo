internal class Program
{
    //mudar TAM=10
    const int TAM=3;
    static void LeMatriz (int[,] mat)
    {
        for (int i=0; i<mat.GetLength(0); i++)
        {
            for (int j=0; j<mat.GetLength(1); j++)
            {
                Console.Write("  ({0},{1})=", i, j);
                mat[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    static void InverteMatriz(int[,] mat)
    {
        int[,] mat2=new int[TAM,TAM];

        for (int i=0; i<mat.GetLength(0); i++)
        {
            for (int j=0; j<mat.GetLength(1); j++)
            {
                mat2[j,i]=mat[i,j];
            }
        }
    }
    static void ImprimeMatriz(int[,] mat)
    {
        for (int i=0; i<mat.GetLength(0); i++)
        {
            for (int j=0; j<mat.GetLength(1); j++)
            {
                Console.Write("({0},{1})={2}\n", i, j, mat[i,j]);
            }
        }
    }
    private static void Main(string[] args)
    {
        int[,] mat=new int[TAM,TAM];
       
        Console.Write("Digite os elementos da matriz:\n");
        LeMatriz(mat);

        InverteMatriz(mat);

        Console.Write("\nA matriz invertida é:\n");
        ImprimeMatriz(mat);

        Console.ReadKey();
    }
}
