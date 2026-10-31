using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint2.Task7.V7.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task7.V7.Test;

[TestClass]
public class DataServiceTest
{
    [DataTestMethod]
    [DataRow(0.0, 1.0, true)]
    [DataRow(-1.5, -1.0, true)]
    [DataRow(0.5, 1.0, true)]
    [DataRow(0.0, 0.0, true)]
    [DataRow(0.0, 2.0, true)]
    [DataRow(-2.0, -2.0, true)]
    [DataRow(1.0, 1.0, true)]
    [DataRow(0.0, -0.01, false)]
    [DataRow(0.0, 2.01, false)]
    [DataRow(-2.1, -2.1, false)]
    [DataRow(1.1, 1.1, false)]
    [DataRow(0.5, 0.4, false)]
    public void ValidArea(double x, double y, bool expected) =>
        Assert.AreEqual(expected, new DataService().CheckDotInShadedArea(x, y));
}
