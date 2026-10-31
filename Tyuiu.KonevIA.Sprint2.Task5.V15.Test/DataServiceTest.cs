using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint2.Task5.V15.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task5.V15.Test;

[TestClass]
public class DataServiceTest
{
    [DataTestMethod]
    [DataRow(1, "понедельник")]
    [DataRow(2, "вторник")]
    [DataRow(3, "среда")]
    [DataRow(4, "четверг")]
    [DataRow(5, "пятница")]
    [DataRow(6, "суббота")]
    [DataRow(7, "воскресенье")]
    [DataRow(8, "понедельник")]
    [DataRow(364, "воскресенье")]
    [DataRow(365, "понедельник")]
    public void ValidDay(int k, string expected) =>
        Assert.AreEqual(expected, new DataService().FindDayName(k));

    [DataTestMethod]
    [DataRow(0)]
    [DataRow(366)]
    public void InvalidDay(int k) =>
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new DataService().FindDayName(k));
}
