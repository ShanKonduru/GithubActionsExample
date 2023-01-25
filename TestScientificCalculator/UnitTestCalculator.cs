using ScientificCalculator;

namespace TestScientificCalculator;

[TestClass]
public class UnitTestCalculator
{
    [TestMethod]
    public void TestAddMethod()
    {
        int result = Calculator.Add(10, 20);
        Assert.AreEqual(30, result, "Addition of 10 and 20 should result 30");
    }
}