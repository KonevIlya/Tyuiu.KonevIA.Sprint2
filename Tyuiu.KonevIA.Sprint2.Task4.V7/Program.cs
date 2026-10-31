using Tyuiu.KonevIA.Sprint2.Task4.V7.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task4.V7;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #2 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #2");
        Line("Тема: Тернарный оператор");
        Line("Задание #4");
        Line("Вариант #7");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Если x - 10 > y + 2: z = (1 + sqrt(x + 3) / x^2)^y;");
        Line("иначе: z = x^3 + 2*x + (6 + 4/y^2).");
        Line("Использовать тернарный оператор. Округлить до трёх знаков.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        Console.Write("Введите X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите Y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        double result = new DataService().Calculate(x, y);
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(double.IsFinite(result)
            ? result.ToString()
            : "Для данных X и Y выражение не определено в действительных числах.");
        Console.ReadLine();
    }
}
