using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KonevIA.Sprint2.Task4.V7.Lib;

public class DataService : ISprint2Task4V7
{
    public double Calculate(double x, double y) => Math.Round(
        x - 10 > y + 2
            ? Math.Pow(1 + Math.Sqrt(x + 3) / Math.Pow(x, 2), y)
            : Math.Pow(x, 3) + 2 * x + (6 + 4 / Math.Pow(y, 2)), 3);
}
