//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении) 
//и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также арифметических выражений, 
//которая вернет логическую последовательность(массив): (False, False, True, False, True, False), при a = 145, b = 156, c = 142, d = 117
using Tyuiu.PlesovskikhBA.Sprint2.Task1.V11.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint2.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {                                       
        [TestMethod]
        public void ValidGetLogicOperation()
        {
            DataService ds = new DataService();
            int a = 145;
            int b = 156;
            int c = 142;
            int d = 117;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
