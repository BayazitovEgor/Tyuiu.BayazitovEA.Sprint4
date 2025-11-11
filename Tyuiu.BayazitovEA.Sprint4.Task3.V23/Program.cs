using Tyuiu.BayazitovEA.Sprint4.Task3.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] array = new int[5, 5] {{ 7, 5, 5, 6, 7 },

{ 8, 7, 8, 4, 3 },

{ 5, 6, 7, 8, 3 },

{ 4, 2, 3, 6, 4},

{5, 2, 4, 2, 3,}};
    DataService ds = new DataService();
        int res = ds.Calculate(array);
        Console.WriteLine(res);
    }
}