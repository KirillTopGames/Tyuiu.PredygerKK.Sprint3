using Tyuiu.PredygerKK.Sprint3.Task6.V25.Lib;

namespace Tyuiu.PredygerKK.Sprint3.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int startValue = 16;
            int stopValue = 24;
            Assert.AreEqual(89, ds.GetSumTheDivisors(startValue, stopValue));
        }
    }
}