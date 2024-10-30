using Tyuiu.PredygerKK.Sprint3.Task7.V21.Lib;

namespace Tyuiu.PredygerKK.Sprint3.Task7.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue, stopValue;
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Предыгер К.К. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Предыгер Кирилл Константинович | ПКТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции.           *");
            Console.WriteLine("* Произвести табулирование. f(x) на заданном диапазоне [-5; 5] с шагом 1. *");
            Console.WriteLine("* Произвести проверку деления на ноль.                                    *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            startValue = -5;
            stopValue = 5;

            Console.WriteLine("Начало шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] TempArray = new double[len];

            TempArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-----------+----------+");
            Console.WriteLine("|     X     |   f(x)   |");
            Console.WriteLine("+-----------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}      |{1, 6:f2}    |", startValue, TempArray[i]);
                startValue++;
            }
            Console.WriteLine("+-----------+----------+");
        }
    }
}
