using Tyuiu.BayazitovEA.Sprint4.Task6.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        var week = new string[] { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };
        string[] nums = ds.Calculate(week);
        foreach (string city in nums)
        {
            Console.WriteLine(city);
        }

        Console.ReadLine();
    }

}   