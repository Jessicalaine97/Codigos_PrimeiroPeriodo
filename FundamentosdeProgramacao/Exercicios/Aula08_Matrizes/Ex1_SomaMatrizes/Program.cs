internal class Program
{
    static void LeMatriz (double[,] mat1)
    {
        //int linhas=mat.GetLenght(0) -> 1° dimensao (n° linhas=3);
        //int linhas=mat.GetLenght(1) -> 2° dimensao (n° colunas=3);

        for (int i=0; i<3; i++)
        {
            for (int j=0; j<3; j++)
            {
                Console.Write("({0},{1})=", i, j);
                mat1[i,j]=Convert.ToDouble(Console.ReadLine());
            }
        }
    }
    static void SomaMatriz(double[,] mat1, double[,] mat2)
    {
        //i<mat.GetLenght(0)
        for (int i=0; i<3; i++)
        {
            //i<mat.GetLenght(1)
            for (int j=0; j<3; j++)
            {
                Console.Write(" \n({0},{1})={2}", i, j, mat1[i,j] + mat2[i,j]);
            }
        }
    }
    private static void Main(string[] args)
    {
        double[,] mat1=new double[3,3];
        double[,] mat2=new double[3,3];

        Console.Write("Digite os elementos da 1° matriz:\n");
        LeMatriz(mat1);

        Console.Write("Digite os elementos da 2° matriz:\n");
        LeMatriz(mat2);

        Console.Write("\nMatriz soma das duas informadas:\n");

        SomaMatriz(mat1, mat2);

        Console.ReadKey();
    }
}
