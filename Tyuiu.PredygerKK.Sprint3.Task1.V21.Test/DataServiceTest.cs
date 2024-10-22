using Tyuiu.PredygerKK.Sprint3.Task1.V21.Lib;

namespace Tyuiu.PredygerKK.Sprint3.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 12;
            double res = 7.086;
            Assert.AreEqual(res, ds.GetMultiplySeries(value, startValue, stopValue));
        }
    }
}