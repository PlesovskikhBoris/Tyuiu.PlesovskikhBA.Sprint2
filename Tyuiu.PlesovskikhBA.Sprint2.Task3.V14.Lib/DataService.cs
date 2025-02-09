using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PlesovskikhBA.Sprint2.Task3.V14.Lib
{
    public class DataService : ISprint2Task3V14
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
                y = x - Math.Pow((x + 1) / (x - 1), 3);
            }
            else if (x == 0)
            {
                y = (3 * x * x - Math.Cos(x * x * x) + 10) / (4 * x * x - Math.Sin(x * x * x * x) + 12);
            }
            else if ((x > -18) & (x < 2))
            {
                y = Math.Pow((1 + (1 / (x * x))), x);
            }
            else if (x < -18)
            {
                y = x + 10 * x - (1 / x);
            }
            return Math.Round(y, 3);
        }
    }
}
