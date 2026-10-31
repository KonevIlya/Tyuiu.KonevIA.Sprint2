using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint2.Task1.V15.Lib;

namespace Tyuiu.KonevIA.Sprint2.Task1.V15.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenValuesReturnRequiredSequence() =>
        CollectionAssert.AreEqual(new[] { true, false, false, false, false, true },
            new DataService().GetLogicOperations(415, 616, 134, 127));

    [TestMethod]
    public void EqualValuesVerifyNegationAndExclusiveOr() =>
        CollectionAssert.AreEqual(new[] { true, false, true, false, true, false },
            new DataService().GetLogicOperations(0, 0, 0, 0));

    [TestMethod]
    public void ReversedPairsVerifyComparisons() =>
        CollectionAssert.AreEqual(new[] { false, true, true, false, false, false },
            new DataService().GetLogicOperations(616, 415, 127, 134));
}
