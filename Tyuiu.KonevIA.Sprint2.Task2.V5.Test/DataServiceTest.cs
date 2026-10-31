using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint2.Task2.V5.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task2.V5.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void AllGridCellsMatchPicture()
    {
        string[] picture =
        {
            "...............",
            "...............",
            "..###...#.##...",
            "..###...#.##...",
            "..##########...",
            "....#########..",
            "....####....#..",
            ".....###....#..",
            ".....###.......",
            ".....###.......",
            "..######.......",
            "......####.....",
            "...............",
            "...............",
            "..............."
        };
        var service = new DataService();
        for (int y = 1; y <= 15; y++)
            for (int x = 1; x <= 15; x++)
                Assert.AreEqual(picture[y - 1][x - 1] == '#',
                    service.CheckDotInShadedArea(x, y), $"x={x}, y={y}");
    }

    [DataTestMethod]
    [DataRow(0, 5)]
    [DataRow(16, 5)]
    [DataRow(5, 0)]
    [DataRow(5, 16)]
    [DataRow(-1, -1)]
    public void OutsideGridIsNotShaded(int x, int y) =>
        Assert.IsFalse(new DataService().CheckDotInShadedArea(x, y));
}
