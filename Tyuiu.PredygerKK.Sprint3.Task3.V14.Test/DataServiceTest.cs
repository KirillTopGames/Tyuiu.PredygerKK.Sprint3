using System.ComponentModel.DataAnnotations;
using Tyuiu.PredygerKK.Sprint3.Task3.V14.Lib;

namespace Tyuiu.PredygerKK.Sprint3.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            string value = "dgt ghedd bed";
            char replaceable = 'd';
            char replacement = '’';
            Assert.AreEqual("’gt ghe’’ be’", ds.ReplaceCharInString(value, replaceable, replacement));
        }
    }
}