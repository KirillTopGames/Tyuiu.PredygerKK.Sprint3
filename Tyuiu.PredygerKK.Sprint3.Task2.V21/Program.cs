using Tyuiu.PredygerKK.Sprint3.Task2.V21.Lib;

namespace Tyuiu.PredygerKK.Sprint3.Task2.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value;
            int startValue, stopValue;
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Предыгер К.К. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Предыгер Кирилл Константинович | ПКТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
            Console.WriteLine("* сумму ряда по формуле, при х=1,5                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение x: ");
            value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите нижнее(начальное) значение: ");
            startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите верхнее(конечное) значение: ");
            stopValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSeries(value, startValue, stopValue));
        }
    }
}
