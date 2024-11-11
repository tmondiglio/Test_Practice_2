namespace Classes;

public class ListaTests
{
    [Test]
    public void getHead_EqualToPosition0()
    {
        int[] lista = [2,2,3]; // Arrange
        Lista l = new Lista(lista); // Arrange

        int result = l.getHead(); // Act

        Assert.AreEqual(expected: 1, actual: result); // Assert
    }

    [Test]
    public void getLast_EqualToPosition2()
    {
        int[] lista = [1,2,3];
        Lista l = new Lista(lista); // Arrange

        int result = l.getLast(); // Act

        Assert.AreEqual(expected: 3, actual: result);
    }

    [Test]
    public void isVoid_noVoidArray_isFalse()
    {
        int[] lista = [1,2,3];
        Lista l = new Lista(lista);
        Assert.AreEqual(expected: false, actual: l.isVoid());
    }


    [Test]
    public void isVoid_VoidArray_isTrue()
    {
        int[] lista = [];
        Lista l = new Lista(lista); // Array

        bool result = l.isVoid();

        Assert.IsFalse(result, "La condicion no es verdadera");
    }    
}