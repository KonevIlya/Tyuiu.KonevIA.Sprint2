using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint2.Task4.V7.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task4.V7.Test;

[TestClass]
public class DataServiceTest
{
    [DataTestMethod]
    [DataRow(15.0, 2.0, 1.038)]
    [DataRow(20.0, 3.0, 1.036)]
    [DataRow(2.0, 2.0, 19.0)]
    [DataRow(14.0, 2.0, 2779.0)]
    [DataRow(-2.0, -1.0, -2.0)]
    public void ValidBranches(double x, double y, double expected) =>
        Assert.AreEqual(expected, new DataService().Calculate(x, y), 1e-10);
}
