using Tyuiu.PredygerKK.Sprint3.Task3.V14.Lib;

namespace Tyuiu.PredygerKK.Sprint3.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            char replaceable, replacement;
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Предыгер К.К. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Предыгер Кирилл Константинович | ПКТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы d  на ’ в строке: dgt ghedd bed   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите исходную строку: ");
            value = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите заменяемый символ: ");
            replaceable = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите заменяющий символ: ");
            replacement = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.ReplaceCharInString(value, replaceable, replacement));
        }
    }
}
