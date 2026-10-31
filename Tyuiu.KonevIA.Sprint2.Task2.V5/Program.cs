using Tyuiu.KonevIA.Sprint2.Task2.V5.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task2.V5;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #2 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #2");
        Line("Тема: Проверка принадлежности точки заштрихованной области");
        Line("Задание #2");
        Line("Вариант #5");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Ввести целые координаты X, Y и проверить, находится ли точка");
        Line("в заштрихованной области по рисунку варианта 5.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        Console.Write("Введите X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите Y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().CheckDotInShadedArea(x, y));
        Console.ReadLine();
    }
}
