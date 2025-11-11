using Tyuiu.BayazitovEA.Sprint4.Task7.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int n = 4;
        int m = 2;
        int[,]mtrx=new int[n,m];
        string str = "56789012";
        DataService ds = new DataService(); ;
        int index=0 ;

        int res = ds.Calculate(n, m, str);
        Console.WriteLine(res);
        Console.ReadKey();

    }
}