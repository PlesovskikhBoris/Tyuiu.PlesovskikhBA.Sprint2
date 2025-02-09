using Tyuiu.PlesovskikhBA.Sprint2.Task3.V14.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint2.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Плесовских Б. А. | СМАРТб-24-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                       *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                             *");
            Console.WriteLine("* Задание #3                                                                      *");
            Console.WriteLine("* Вариант #14                                                                     *");
            Console.WriteLine("* Выполнил: Плесовских Борис Александрович | СМАРТб-24-1                          *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y              *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь                   *");
            Console.WriteLine("* вводит значение переменной X с клавиатуры. Округлить полученное значение        *");
            Console.WriteLine("* до трех знаков после запятой.                                                    *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("Введите значение X :  ");
            int x = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(x);
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                      *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("Значение функции: " + res);
        }
    }
}
