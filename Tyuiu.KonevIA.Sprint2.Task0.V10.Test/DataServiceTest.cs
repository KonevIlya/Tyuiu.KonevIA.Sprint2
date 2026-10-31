using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint2.Task0.V10.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task0.V10.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenValuesReturnRequiredSequence() =>
        CollectionAssert.AreEqual(new[] { false, true, false, true, false, true },
            new DataService().GetCompareOperations(1305, 475));

    [TestMethod]
    public void EqualValuesPreserveOperatorOrder() =>
        CollectionAssert.AreEqual(new[] { true, false, false, false, true, true },
            new DataService().GetCompareOperations(475, 475));

    [TestMethod]
    public void SmallerFirstValuePreservesOperatorOrder() =>
        CollectionAssert.AreEqual(new[] { false, true, true, false, true, false },
            new DataService().GetCompareOperations(475, 1305));
}
