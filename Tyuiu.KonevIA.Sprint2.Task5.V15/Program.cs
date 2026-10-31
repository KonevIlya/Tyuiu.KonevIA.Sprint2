using Tyuiu.KonevIA.Sprint2.Task5.V15.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task5.V15;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #2 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #2");
        Line("Тема: Оператор switch");
        Line("Задание #5");
        Line("Вариант #15");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Определить день недели для k-го дня невисокосного года,");
        Line("если 1 января — понедельник. 1 <= k <= 365.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        Console.Write("Введите номер дня k: ");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        if (k >= 1 && k <= 365)
            Console.WriteLine(new DataService().FindDayName(k));
        else
            Console.WriteLine("Номер дня должен быть от 1 до 365.");
        Console.ReadLine();
    }
}
