using Tyuiu.BayazitovEA.Sprint4.Task7.V11.Lib;
namespace Tyuiu.BayazitovEA.Sprint4.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 3;
            int cols = 3;
            int[,] mtrx= new int[rows, cols];
            string str = "103050709";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, cols, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
