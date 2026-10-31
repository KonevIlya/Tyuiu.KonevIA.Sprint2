using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint2.Task5.V15.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task5.V15.Test;

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
    [DataRow(8, "Понедельник")]
    [DataRow(364, "Воскресенье")]
    [DataRow(365, "Понедельник")]
    public void ValidDay(int k, string expected) =>
        Assert.AreEqual(expected, new DataService().FindDayName(k));

    [DataTestMethod]
    [DataRow(0)]
    [DataRow(366)]
    public void InvalidDay(int k) =>
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new DataService().FindDayName(k));
}

