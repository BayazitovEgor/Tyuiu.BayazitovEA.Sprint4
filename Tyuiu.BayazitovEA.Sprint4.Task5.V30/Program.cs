using Tyuiu.BayazitovEA.Sprint4.Task5.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();
        int[,] numsArry = new int[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                numsArry[i, j] = rnd.Next(-2, 4);
            }
        }
        int res = ds.Calculate(numsArry);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}