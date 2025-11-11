using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BayazitovEA.Sprint4.Task3.V23.Lib
{
    public class DataService : ISprint4Task3V23
    {
        public int Calculate(int[,] array)
        {
            int rows = 5;
            int cols = 5;
            int count = 0;
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    if (array[i, j]%2==0)
                    {
                        count++;
                    }
                } }
            return count;
        }
    } }
