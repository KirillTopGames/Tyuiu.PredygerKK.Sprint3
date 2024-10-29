using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PredygerKK.Sprint3.Task5.V19.Lib
{
    public class DataService : ISprint3Task5V19
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            int i, k;
            for (i = startValue1; i <= stopValue2; i++)
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    res += Math.Pow(x / Math.Cos(x), k);
                }
            }
            return Math.Round(res, 3) / 2;
        }
    }
}
