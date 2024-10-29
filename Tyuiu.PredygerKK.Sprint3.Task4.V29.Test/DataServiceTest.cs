using Tyuiu.PredygerKK.Sprint3.Task4.V29.Lib;

namespace Tyuiu.PredygerKK.Sprint3.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int startValue = -5; int stopValue = 5;
            double res = 0.104;
            Assert.AreEqual(res, ds.Calculate(startValue, stopValue));
        }
    }
}