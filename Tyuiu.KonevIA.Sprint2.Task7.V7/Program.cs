using Tyuiu.KonevIA.Sprint2.Task7.V7.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task7.V7;

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
        Line("Задание #7");
        Line("Вариант #7");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Ввести вещественные X, Y. Проверить принадлежность области:");
        Line("y >= x и y <= 2 - x^2 (границы включены).");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        Console.Write("Введите X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите Y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().CheckDotInShadedArea(x, y));
        Console.ReadLine();
    }
}

