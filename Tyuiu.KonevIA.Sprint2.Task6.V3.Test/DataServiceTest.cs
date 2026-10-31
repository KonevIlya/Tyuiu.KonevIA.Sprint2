using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint2.Task6.V3.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task6.V3.Test;

[TestClass]
public class DataServiceTest
{
    [DataTestMethod]
    [DataRow(1, "Понедельник")]
    [DataRow(2, "Вторник")]
    [DataRow(3, "Среда")]
    [DataRow(4, "Четверг")]
    [DataRow(5, "Пятница")]
    [DataRow(6, "Суббота")]
    [DataRow(7, "Воскресенье")]
    public void ValidDay(int value, string expected) =>
        Assert.AreEqual(expected, new DataService().FindDayName(value));

    [DataTestMethod]
    [DataRow(0)]
    [DataRow(8)]
    public void InvalidDay(int value) =>
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new DataService().FindDayName(value));
}
