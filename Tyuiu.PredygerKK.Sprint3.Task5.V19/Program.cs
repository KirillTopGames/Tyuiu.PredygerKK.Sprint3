using Tyuiu.PredygerKK.Sprint3.Task5.V19.Lib;

namespace Tyuiu.PredygerKK.Sprint3.Task5.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue1, stopValue1, stopValue2, startValue2, x;
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Предыгер К.К. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Предыгер Кирилл Константинович | ПКТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* при X = 2                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите начальное(нижнее) значение внешней(первой) суммы:");
            startValue1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конечное(верхнее) значение внешней(первой) суммы:");
            stopValue1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите начальное(нижнее) значение внутренней(второй) суммы:");
            startValue2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конечное(верхнее) значение внутренней(второй) суммы:");
            stopValue2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной x(2):");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
        }
    }
}
