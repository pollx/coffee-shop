﻿namespace CoffeeShop.LogicTests.CoffeeTests.CoffeeTypeTests
{
    using Logic.Coffee;
    using Logic.Coffee.Abstract;
    using Logic.Coffee.CoffeeTypes.PlovdivStoreSpecialTypes;
    using NUnit.Framework;

    [TestFixture]
    public class Ristretto_Should
    {
        [Test]
        public void RistrettoClass_ShouldImplementICoffeeInterface()
        {
            // Arrange
            var coffeeSize = CoffeSizeType.Medium;

            // Act
            var obj = new Ristretto(coffeeSize);

            // Assert
            Assert.That(obj, Is.InstanceOf<ICoffee>());
        }

        [Test]
        public void RistrettoClass_ShouldInheritCoffeeAbstractClass()
        {
            // Arrange
            var coffeeSize = CoffeSizeType.Medium;

            // Act
            var obj = new Ristretto(coffeeSize);

            // Assert
            Assert.That(obj, Is.InstanceOf<Coffee>());
        }

        [Test]
        public void RistrettoClass_Countructor_ShouldInitializeObjectCorrectly()
        {
            // Arrange
            var coffeeSize = CoffeSizeType.Medium;

            // Act
            var obj = new Ristretto(coffeeSize);

            // Assert
            Assert.That(obj, Is.InstanceOf<Ristretto>());
        }

        [Test]
        public void RistrettoClass_Countructor_ShouldSetDescriptionCorrectly()
        {
            // Arrange
            var coffeeSize = CoffeSizeType.Medium;
            var expectedDescription = "Ristretto";

            // Act
            var obj = new Ristretto(coffeeSize);

            // Assert
            Assert.That(obj.FullDescription, Does.Contain(expectedDescription));
        }

        [Test]
        public void RistrettoClass_Countructor_ShouldSetSizeCorrectly()
        {
            // Arrange
            var coffeeSize = CoffeSizeType.Medium;
            var expectedSize = coffeeSize.ToString();

            // Act
            var obj = new Ristretto(coffeeSize);

            // Assert
            Assert.That(obj.FullDescription, Does.Contain(expectedSize));
        }

        [Test]
        public void RistrettoClass_FullDescriptionProperty_ShouldExists()
        {
            // Arrange
            var coffeeSize = CoffeSizeType.Medium;

            // Act
            var obj = new Ristretto(coffeeSize);

            // Assert
            Assert.That(obj, Has.Property("FullDescription"));
        }

        [Test]
        public void RistrettoClass_FullDescriptionProperty_ShouldReturnCorrectFullDescription()
        {
            // Arrange
            var coffeeSize = CoffeSizeType.Medium;
            var expectedDescription = "Ristretto";
            var expectedSize = coffeeSize.ToString();
            var expectedFullDescription = expectedSize + " " + expectedDescription;

            // Act
            var obj = new Ristretto(coffeeSize);

            // Assert
            Assert.That(obj, Has.Property("FullDescription").EqualTo(expectedFullDescription));
        }

        [TestCase(CoffeSizeType.Small)]
        [TestCase(CoffeSizeType.Medium)]
        [TestCase(CoffeSizeType.Grande)]
        public void RistrettoClass_CostMethod_ShouldReturnCorrectPriceBasedOnCoffeSize(CoffeSizeType coffeeSize)
        {
            // Arrange
            var basePrice = 1.50m;
            var expectedCost = basePrice + (((int)coffeeSize / 100) * basePrice);

            // Act
            var obj = new Ristretto(coffeeSize);

            // Assert
            Assert.That(obj.Cost(), Is.EqualTo(expectedCost));
        }

        [Test]
        public void RistrettoClass_IdProperty_ShouldReturnCorrectId()
        {
            // Arrange
            var coffeeSize = CoffeSizeType.Medium;
            var expectedId = "RIS";

            // Act
            var obj = new Ristretto(coffeeSize);

            // Assert
            Assert.That(obj, Has.Property("Id").EqualTo(expectedId));
        }
    }
}
