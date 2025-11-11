using Tyuiu.BayazitovEA.Sprint4.Task4.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int[,] matrix = new int[5, 5];


        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {

                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int[,] result = ds.Calculate(matrix);

        PrintMatrix(result);

        Console.ReadKey();
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}