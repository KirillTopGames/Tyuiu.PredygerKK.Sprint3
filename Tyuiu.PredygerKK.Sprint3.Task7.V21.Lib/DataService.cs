using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PredygerKK.Sprint3.Task7.V21.Lib
{
    public class DataService : ISprint3Task7V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int cnt = 0;
            double y;
            double[] res;
            int len = stopValue - startValue + 1;
            res = new double[len];
            for (int x = -5; x <= 5; x++)
            {
                if (2*x - 1 == 0)
                {
                    res[cnt] = 0;
                    continue;
                }
                else
                {
                    y = Math.Round((2 * Math.Cos(x) + 2) / (2 * x - 1) + Math.Cos(x) - 5 * x + 3, 2);


                    res[cnt] = y;
                }
                cnt++;
            }
            return res;
        }
    }
}
