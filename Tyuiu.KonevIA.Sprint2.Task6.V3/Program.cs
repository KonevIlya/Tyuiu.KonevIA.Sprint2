using Tyuiu.KonevIA.Sprint2.Task6.V3.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task6.V3;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #2 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #2");
        Line("Тема: Сокращённая форма оператора switch");
        Line("Задание #6");
        Line("Вариант #3");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("По порядковому номеру дня недели (1, 2, ..., 7)");
        Line("вывести его название с помощью switch-выражения.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        Console.Write("Введите номер дня k: ");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        if (k >= 1 && k <= 7)
            Console.WriteLine(new DataService().FindDayName(k));
        else
            Console.WriteLine("Номер дня должен быть от 1 до 7.");
        Console.ReadLine();
    }
}

