using Tyuiu.BayazitovEA.Sprint4.Task2.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd= new Random();
        DataService ds = new DataService();
        int len = Convert.ToInt32(Console.ReadLine());
        int[] numsArry = new int[len];
        for (int i = 0; i <= len - 1; i++)
        {
            numsArry[i] = rnd.Next(5,20);
        }
        int res = ds.Calculate(numsArry);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}