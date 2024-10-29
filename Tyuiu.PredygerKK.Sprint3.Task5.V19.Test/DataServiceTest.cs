using Tyuiu.PredygerKK.Sprint3.Task5.V19.Lib;

namespace Tyuiu.PredygerKK.Sprint3.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int x, startValue1, startValue2, stopValue1, stopValue2;
            x = 2;
            stopValue1 = 3;
            stopValue2 = 6;
            startValue1 = 1;
            startValue2 = 1;
            double res = 61196.004;
            Assert.AreEqual(res, ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
        }
    }
}