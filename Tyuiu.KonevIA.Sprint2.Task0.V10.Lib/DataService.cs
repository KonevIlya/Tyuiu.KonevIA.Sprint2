using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KonevIA.Sprint2.Task0.V10.Lib;

public class DataService : ISprint2Task0V10
{
    public bool[] GetCompareOperations(int x, int y) => new bool[]
    {
        x == y,
        x != y,
        x < y,
        x > y,
        x <= y,
        x >= y
    };
}
