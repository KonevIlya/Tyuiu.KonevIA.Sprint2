using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint2.Task3.V3.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task3.V3.Test;

[TestClass]
public class DataServiceTest
{
    [DataTestMethod]
    [DataRow(2.0, 18.0)]
    [DataRow(3.0, 24.0)]
    [DataRow(0.0, 0.167)]
    [DataRow(-1.0, 0.414)]
    [DataRow(-2.0, 0.64)]
    [DataRow(-3.0, 1.0)]
    [DataRow(-8.0, -15.875)]
    [DataRow(-10.0, 0.1)]
    public void ValidBranches(double x, double expected) =>
        Assert.AreEqual(expected, new DataService().Calculate(x), 1e-10);

    [DataTestMethod]
    [DataRow(-7.0)]
    [DataRow(-4.0)]
    [DataRow(0.5)]
    [DataRow(1.0)]
    public void UndefinedValuesReturnNaN(double x) =>
        Assert.IsTrue(double.IsNaN(new DataService().Calculate(x)));
}
