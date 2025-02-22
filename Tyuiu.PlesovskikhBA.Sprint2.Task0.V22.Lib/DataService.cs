﻿//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)
//и арифметических выражений, которая вернет логическую последовательность(массив): (False, True, True, True, True, False),),
//при x = 3105, y = 77
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PlesovskikhBA.Sprint2.Task0.V22.Lib
{
    public class DataService : ISprint2Task0V22
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y;
            res[1] = x != y;
            res[2] = x - 3029 < y;
            res[3] = x > y;
            res[4] = x - 3028 == y;
            res[5] = x - 3100 >= y;
            return res;
        }
    }
}
