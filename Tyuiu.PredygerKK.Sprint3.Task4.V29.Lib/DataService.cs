using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PredygerKK.Sprint3.Task4.V29.Lib
{
    public class DataService : ISprint3Task4V29
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            int x;
            for (x = startValue; x <= stopValue; x++) 
            {
                if (x == 0)
                {
                    continue;
                }
                else
                {
                    res += Math.Cos(x) / x;
                }
            }
            return Math.Round(res, 3);
        }
    }
}
