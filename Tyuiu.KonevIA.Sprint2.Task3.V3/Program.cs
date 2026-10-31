using Tyuiu.KonevIA.Sprint2.Task3.V3.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task3.V3;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #2 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #2");
        Line("Тема: Вложенные операторы if-else");
        Line("Задание #3");
        Line("Вариант #3");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Вычислить функцию Y с помощью вложенных if-else:");
        Line("x > 1:      x * ((x + 1) / (x - 1))^x");
        Line("x = 0:      (x^4 - cos(x^5) + 3) / (x^2 - sin(x^2) + 12)");
        Line("-7 < x < 0: (1 + sqrt(x + 3) / x^2)^x");
        Line("x < -7:     x^2 + 10*x - 1/x");
        Line("Округлить результат до трёх знаков после запятой.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        Console.Write("Введите X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double result = new DataService().Calculate(x);
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        if (double.IsNaN(result))
            Console.WriteLine("Для данного X функция не определена в действительных числах.");
        else
            Console.WriteLine(result);
        Console.ReadLine();
    }
}
