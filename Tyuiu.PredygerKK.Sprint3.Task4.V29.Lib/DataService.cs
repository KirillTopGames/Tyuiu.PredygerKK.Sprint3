using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PredygerKK.Sprint3.Task4.V29.Lib
{
    public class DataService : ISprint3Task4V29
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            int x = -5;
            while (x != 0 && x <= 5)
            {
                res += Math.Cos(x) / x;
                x++;
            }
            return Math.Round(res, 3);
        }
    }
}
