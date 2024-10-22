using Tyuiu.PredygerKK.Sprint3.Task0.V8.Lib;

namespace Tyuiu.PredygerKK.Sprint3.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int startValue, stopValue; double value;
            startValue = 1;
            stopValue = 10;
            value = 0.25;
            double res = -6.754;
            Assert.AreEqual(res, ds.GetMultiplySeries(value, startValue, stopValue));
        }
    }
}