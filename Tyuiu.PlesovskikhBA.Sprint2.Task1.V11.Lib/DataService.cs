//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении) 
//и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также арифметических выражений, 
//которая вернет логическую последовательность(массив): (False, False, True, False, True, False), при a = 145, b = 156, c = 142, d = 117
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PlesovskikhBA.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a + 25 < b) | (c < d); //false
            res[1] = (a + 2 > b) & (c < d); //false
            res[2] = (a + 50 > b) || (c < d); //true
            res[3] = (a + 2 > b) && (c < d); //false
            res[4] = !(res[0]); //true
            res[5] = (a + 50 > b) ^ (c - 100 < d); //false
            return res;
        }
    }
}
