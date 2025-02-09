//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)
//и арифметических выражений, которая вернет логическую последовательность(массив): (False, True, True, True, True, False),),
//при x = 3105, y = 77
using Tyuiu.PlesovskikhBA.Sprint2.Task0.V22.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint2.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            DataService ds = new DataService();
            int x = 3105;
            int y = 77;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.Title = "Спринт #2 | Выполнил: Плесовских Б. А. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Плесовских Борис Александрович | СМАРТб-24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность операций не должна нарушаться)                       *");
            Console.WriteLine("* и арифметических выражений которая вернет логическую последовательность *");
            Console.WriteLine("* (массив): (False, True, True, True, True, False), при x = 3105, y = 77  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение X :  " + x);
            Console.WriteLine("Значение Y :  " + y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
