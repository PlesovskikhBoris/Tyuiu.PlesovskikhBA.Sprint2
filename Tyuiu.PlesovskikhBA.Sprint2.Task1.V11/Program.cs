//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении) 
//и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также арифметических выражений, 
//которая вернет логическую последовательность(массив): (False, False, True, False, True, False), при a = 145, b = 156, c = 142, d = 117
using Tyuiu.PlesovskikhBA.Sprint2.Task1.V11.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint2.Task1.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 145;
            int b = 156;
            int c = 142;
            int d = 117;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.Title = "Спринт #2 | Выполнил: Плесовских Б. А. | СМАРТб-24-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                       *");
            Console.WriteLine("* Тема: Логические операции                                                       *");
            Console.WriteLine("* Задание #1                                                                      *");
            Console.WriteLine("* Вариант #11                                                                     *");
            Console.WriteLine("* Выполнил: Плесовских Борис Александрович | СМАРТб-24-1                          *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,                 *");
            Console.WriteLine("* последовательность можно чередовать но использовать один раз в выражении        *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций          *");
            Console.WriteLine("* не должна нарушаться), а также арифметических выражений, которая вернет         *");
            Console.WriteLine("* логическую последовательность(массив): (False, False, True, False, True, False) *");
            Console.WriteLine("* при a = 145, b = 156, c = 142, d = 117                                          *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("Значение X :  " + a);
            Console.WriteLine("Значение Y :  " + b);
            Console.WriteLine("Значение C :  " + c);
            Console.WriteLine("Значение D :  " + d);
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                      *");
            Console.WriteLine("***********************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
