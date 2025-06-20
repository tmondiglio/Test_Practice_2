using Classes;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class ListaTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetTail_SingleElementList_ReturnsEmptyArray()
        {

            int[] originalList = new int[] { 100 };
            Lista l = new Lista(originalList);


            int[] actualTail = l.getTail();


            Assert.That(actualTail, Is.Empty, "La lista debe estar vacia cuando solo hay un elemento en la lista original.");

        }

        [Test]
        public void GetTail_MultipleElementsList_ReturnsCorrectTail()
        {

            int[] originalList = new int[] { 15, 25, 35, 45, 55 };
            Lista l = new Lista(originalList);
            int[] expectedTail = new int[] { 25, 35, 45, 55 };


            int[] actualTail = l.getTail();


            Assert.That(actualTail, Is.EqualTo(expectedTail), "Los elementos de la lista no son los correctos.");
        }
        [Test]
        public void GetTail_ReturnedArrayIsOneElementShorterThanOriginal()
        {

            int[] originalList = new int[] { 10, 20, 30, 40 };
            Lista l = new Lista(originalList);


            int[] actualTail = l.getTail();

            Assert.That(actualTail.Length, Is.EqualTo(originalList.Length - 1),
                "La lista nueva deberia ser menor a la original en 1 elemento.");
        }
        [Test]
        public void GetTail_ListWithRepeatedValues_ReturnsCorrectTail()
        {

            int[] originalList = new int[] { 9, 9, 9, 9, 9 };
            Lista l = new Lista(originalList);
            int[] expectedTail = new int[] { 9, 9, 9, 9 };


            int[] actualTail = l.getTail();


            Assert.That(actualTail, Is.EqualTo(expectedTail), "La lista deberia tener los mismos valores repetidos que la original, menos el primero.");
        }
        [Test]
        public void GetTail_MixedSignedValues_ReturnsExpectedTail()
        {
            int[] originalList = new int[] { -3, 0, 5, -9, 99 };
            Lista l = new Lista(originalList);
            int[] expectedTail = new int[] { 0, 5, -9, 99 };

            int[] actualTail = l.getTail();


            Assert.That(actualTail, Is.EqualTo(expectedTail), "La lista debería tener todos los valores: ceros, negativos y positivos (excepto el primero).");
        }
        [Test]
        public void GetTail_ListWithExtremeIntValues()
        {
            
            int[] originalList = new int[] { 0, int.MaxValue, int.MinValue, 9999 };
            Lista l = new Lista(originalList);
            int[] expectedTail = new int[] { int.MaxValue, int.MinValue, 9999 };

            
            int[] actualTail = l.getTail();

            
            Assert.That(actualTail, Is.EqualTo(expectedTail),"La lista devuelta debería contener correctamente los valores extremos como int.MaxValue e int.MinValue.");
        }
    }
}
