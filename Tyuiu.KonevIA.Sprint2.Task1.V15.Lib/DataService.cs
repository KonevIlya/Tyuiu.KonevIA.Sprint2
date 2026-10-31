using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KonevIA.Sprint2.Task1.V15.Lib;

public class DataService : ISprint2Task1V15
{
    public bool[] GetLogicOperations(int a, int b, int c, int d) => new bool[]
    {
        (a < b) | (c == d),
        (a > b) & (c != d),
        (a >= b) || (c < d),
        (a <= d) && (b > c),
        !(a + b > c + d),
        (a == b) ^ (c >= d)
    };
}
