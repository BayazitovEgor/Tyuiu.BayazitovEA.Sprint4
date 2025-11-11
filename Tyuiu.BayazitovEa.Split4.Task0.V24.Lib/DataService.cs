using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BayazitovEa.Split4.Task0.V24.Lib
{
    public class DataService : ISprint4Task0V24
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int product = 1;
            for ( int i = 0; i <= array.Length - 1; i++ )
            {
                if (array[i]%2==0)
                { 
                    product = product*array[i]; 
                }
            }
            return product;
        }
    }
}
