using Tyuiu.PlesovskikhBA.Sprint2.Task6.V15.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string res = ds.FindDayName(7);
            Assert.AreEqual("Воскресенье", res);
        }
    }
}