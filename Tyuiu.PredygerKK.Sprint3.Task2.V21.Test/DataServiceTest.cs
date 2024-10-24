using Tyuiu.PredygerKK.Sprint3.Task2.V21.Lib;

namespace Tyuiu.PredygerKK.Sprint3.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            double value = 1.5;
            int startValue = 1;
            int stopValue = 10;
            Assert.AreEqual(0.298, ds.GetSumSeries(value, startValue, stopValue));
        }
    }
}