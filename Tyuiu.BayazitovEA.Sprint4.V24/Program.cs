using Tyuiu.BayazitovEA.Sprint4.V24.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[] numArray = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

        Console.WriteLine(ds.GetMultEvenArrEl(numArray));
        Console.ReadKey();
    }
}