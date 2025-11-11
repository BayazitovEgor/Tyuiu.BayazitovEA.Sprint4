using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BayazitovEA.Sprint4.Task5.V30.Lib
{
    public class DataService : ISprint4Task5V30
    {
        public int Calculate(int[,] matrix)
        {
            {
                int rows = 5;
                int cols = 5;
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i, j] > 0 )
                        {
                            sum += matrix[i, j];
                        }
                    }
                }
                return sum;
            }
        }
    }
}
