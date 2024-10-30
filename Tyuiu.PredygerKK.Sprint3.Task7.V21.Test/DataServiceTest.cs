using Tyuiu.PredygerKK.Sprint3.Task7.V21.Lib;


namespace Tyuiu.PredygerKK.Sprint3.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] TempArray;
            TempArray = new double[len];

            TempArray[0] = 0.24;
            TempArray[1] = 0.04;
            TempArray[2] = 0.84;
            TempArray[3] = 0.24;
            TempArray[4] = 0.24;
            TempArray[5] = 0.24;
            TempArray[6] = 0.24;
            TempArray[7] = 0.24;
            TempArray[8] = 0.24;
            TempArray[9] = 0.24;
            TempArray[10] = 0.24;

            TempArray[0] = 0.23;
            
            CollectionAssert.AreEqual(TempArray, ds.GetMassFunction(startValue, stopValue));
        }
    }
} 