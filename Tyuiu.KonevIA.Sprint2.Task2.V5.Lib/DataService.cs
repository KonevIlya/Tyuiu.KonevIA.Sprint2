using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KonevIA.Sprint2.Task2.V5.Lib;

public class DataService : ISprint2Task2V5
{
    public bool CheckDotInShadedArea(int x, int y) =>
        (y >= 3 && y <= 4 && ((x >= 3 && x <= 5) || x == 9 || (x >= 11 && x <= 12)))
        || (y == 5 && x >= 3 && x <= 12)
        || (y == 6 && x >= 5 && x <= 13)
        || (y == 7 && ((x >= 5 && x <= 8) || x == 13))
        || (y == 8 && ((x >= 6 && x <= 8) || x == 13))
        || (y >= 9 && y <= 10 && x >= 6 && x <= 8)
        || (y == 11 && x >= 3 && x <= 8)
        || (y == 12 && x >= 7 && x <= 10);
}
