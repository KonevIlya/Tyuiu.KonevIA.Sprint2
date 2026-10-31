using Tyuiu.KonevIA.Sprint2.Task1.V15.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task1.V15;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #2 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #2");
        Line("Тема: Логические операции");
        Line("Задание #1");
        Line("Вариант #15");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Используя сравнения и операции |, &, ||, &&, !, ^ по порядку,");
        Line("получить массив (True, False, False, False, False, True).");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int a = 415;
        int b = 616;
        int c = 134;
        int d = 127;
        Line($"a = {a}; b = {b}; c = {c}; d = {d}");
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine("(" + string.Join(", ", new DataService().GetLogicOperations(a, b, c, d)) + ")");
        Console.ReadLine();
    }
}

