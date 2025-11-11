using System.ComponentModel.DataAnnotations;
using Tyuiu.BayazitovEA.Sprint4.Task1.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int len;
        len = Convert.ToInt32(Console.ReadLine());
        int[] numsArry=new int[len];
        for (int i=0;i<=len-1;i++)
        {
            numsArry[i]=Convert.ToInt32(Console.ReadLine());
        }
        int res = ds.Calculate(numsArry);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}