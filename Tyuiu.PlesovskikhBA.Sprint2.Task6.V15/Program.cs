using Tyuiu.PlesovskikhBA.Sprint2.Task6.V15.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint2.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Плесовских Б. А. | СМАРТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Получение результата из switch                                          *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Плесовских Борис Александрович | СМАРТб-24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Написать программу, которая использует сокращенную форму записи оператора*");
            Console.WriteLine("*а switch вычисляет требуемое значение и возвращает результат. Условие: Да*");
            Console.WriteLine("*ано целое число k (1 <= k <= 365). Определить, каким днем недели (понедел*");
            Console.WriteLine("*льником, вторником, …, субботой или воскресеньем) является k-й день не ви*");
            Console.WriteLine("*исокосного года, в котором 1 января понедельник.                         *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите день");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.FindDayName(x);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}