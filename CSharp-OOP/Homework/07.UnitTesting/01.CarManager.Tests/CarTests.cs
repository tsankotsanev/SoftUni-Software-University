using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class CarTests
    {
        private Car car;
        private const string Make = "BMW";
        private const string Model = "BMWX3";
        private const double FuelConsumption = 12;
        private const double FuelAmount = 0;
        private const double FuelCapacity = 70;
        [SetUp]
        public void Setup()
        {
            car = new Car(Make, Model, FuelConsumption, FuelCapacity);
        }

        [Test]
        public void ConstructorSetAmountDefaultZero()
        {
            Assert.AreEqual(0, car.FuelAmount);
        }

        [Test]
        public void ConstructorShouldInitializeCarCorrectly()
        {

            Assert.IsNotNull(car);
        }

        [TestCase(null)]
        [TestCase()]
        public void IfMakeIsNullOrEmptyShouldThrowException(string make)
        {
            Assert.Throws<ArgumentException>(() => car = new Car(make, Model, FuelConsumption, FuelCapacity));
        }

        [TestCase(null)]
        [TestCase()]
        public void IfModelIsNullOrEmptyShouldThrowException(string model)
        {
            Assert.Throws<ArgumentException>(() => car = new Car(Make, model, FuelConsumption, FuelCapacity));
        }

        [TestCase(0)]
        [TestCase(-3)]
        public void IfFuelConsumptionIsZeroOrLessThanZeroShouldThrowException(double fuelConsumption)
        {

            Assert.Throws<ArgumentException>(() => car = new Car(Make, Model, fuelConsumption, FuelCapacity));
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void IfFuelCapacityIsZeroOrLessThanZeroShouldThrowException(double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => car = new Car(Make, Model, FuelConsumption, fuelCapacity));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void RefuelAmountCannotBeZeroOrLessThanZeroShouldThrowException(double fuelToRefuel)
        {
            Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel));
        }

        [TestCase(50)]
        [TestCase(30)]
        public void RefuelOperationShouldSetFuelAmountCorrectly(double fuel)
        {
            car.Refuel(fuel);
            Assert.AreEqual(fuel, car.FuelAmount);
        }
        [TestCase(280)]
        public void RefuelOperationCannotBeMoreThanCapacity(double refuel)
        {
            double expected = 70;
            car.Refuel(refuel);

            Assert.AreEqual(expected, car.FuelAmount);
        }
        [TestCase(20)]
        public void DriveOperationShouldDecrementFuelAmount(double distance)
        {
            car.Refuel(70);
            car.Drive(distance);
            var expectedResult = 67.6;

            Assert.AreEqual(expectedResult, car.FuelAmount);
        }
        [TestCase(2000)]
        public void DistanceISMoreThanFuelAmount(double distance)
        {
            Assert.Throws<InvalidOperationException>(() => car.Drive(distance));
        }

    }
}

