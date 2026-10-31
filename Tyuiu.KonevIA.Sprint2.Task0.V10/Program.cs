using Tyuiu.KonevIA.Sprint2.Task0.V10.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task0.V10;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #2 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #2");
        Line("Тема: Операции сравнения");
        Line("Задание #0");
        Line("Вариант #10");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Используя сравнения ==, !=, <, >, <=, >= в указанном порядке,");
        Line("получить массив (False, True, False, True, False, True).");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int x = 1305;
        int y = 475;
        Line($"x = {x}; y = {y}");
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine("(" + string.Join(", ", new DataService().GetCompareOperations(x, y)) + ")");
        Console.ReadLine();
    }
}
