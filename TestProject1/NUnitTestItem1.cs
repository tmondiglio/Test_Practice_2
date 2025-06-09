using NUnit.Framework;

[TestFixture]
public class AssertionExamples
{
    [Test]
    public void TestAssertAreEqual_1()
    {
        int expected = 5;
        int actual = 5;
        Assert.That(actual, Is.EqualTo(expected), "Los valores no son iguales");
        // Assert.AreEqual(expected, actual, "Los valores no son iguales");
    }

    [Test]
    public void TestAssertAreNotEqual_2()
    {
        int unexpected = 3;
        int actual = 5;
        Assert.That(actual, Is.Not.EqualTo(unexpected), "Los valores no deberían ser iguales");
        // Assert.AreNotEqual(unexpected, actual, "Los valores no deberían ser iguales");
    }

    [Test]
    public void TestAssertIsTrue_3()
    {
        bool condition = true;
        Assert.IsTrue(condition, "La condición no es verdadera");
    }

    [Test]
    public void TestAssertIsFalse_4()
    {
        bool condition = false;
        Assert.IsFalse(condition, "La condición no es falsa");
    }

    [Test]
    public void TestAssertIsNull()
    {
        object? obj = null;
        Assert.IsNull(obj, "El objeto no es nulo");
    }

    [Test]
    public void TestAssertIsNotNull()
    {
        object obj = new object();
        Assert.IsNotNull(obj, "El objeto es nulo");
    }

    [Test]
    public void TestAssertAreSame()
    {
        var obj = new object();
        var reference = obj;
        Assert.That(reference, Is.SameAs(obj), "Las referencias no son iguales");
        // Assert.AreSame(obj, reference, "Las referencias no son iguales");
    }

    [Test]
    public void TestAssertAreNotSame()
    {
        var obj1 = new object();
        var obj2 = new object();
        Assert.That(obj2, Is.Not.SameAs(obj1), "Las referencias no deberían ser iguales");
        // Assert.AreNotSame(obj1, obj2, "Las referencias no deberían ser iguales");
    }

    [Test]
    public void TestAssertThrows()
    {
        Assert.Throws<ArgumentException>(() => throw new ArgumentException(), "No se lanzó la excepción esperada");
    }

    [Test]
    public void TestAssertThat()
    {
        int[] array = { 1, 2, 3 };
        string text = "Hello World";
        Assert.That(array, Has.Exactly(3).Items, "El array no tiene exactamente 3 elementos");
        Assert.That(array, Has.Member(2), "El array no contiene el número 2");
        Assert.That(text, Does.StartWith("Hello").And.EndWith("World"), "El string no comienza y termina como se esperaba");
    }
}
