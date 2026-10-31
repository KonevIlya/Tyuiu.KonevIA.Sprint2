using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint2.Task6.V3.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task6.V3.Test;

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
    public void ValidDay(int value, string expected) =>
        Assert.AreEqual(expected, new DataService().FindDayName(value));

    [DataTestMethod]
    [DataRow(0)]
    [DataRow(8)]
    public void InvalidDay(int value) =>
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new DataService().FindDayName(value));
}

