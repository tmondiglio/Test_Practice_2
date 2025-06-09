using NUnit.Framework;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        int result = 1;
        Assert.AreEqual(expected: 1, actual: result);
    }
}
