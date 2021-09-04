using ExtendedDatabase;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private const int DatabaseCapacity = 16;

        private Person[] people;
        private ExtendedDatabase.ExtendedDatabase extendedDB;

        [SetUp]
        public void Setup()
        {
            extendedDB = new ExtendedDatabase.ExtendedDatabase();
            people = new Person[]
            {
            new Person(2636, "Hihi"),
            new Person(2635, "Lili"),
            new Person(2634, "Kiki"),
            new Person(2633, "Didi"),
            new Person(2632, "Vivi"),
            new Person(2631, "Bibi"),
            new Person(2630, "Titi"),
            new Person(2629, "Jiji"),
            new Person(2628, "Gigi"),
            new Person(2627, "Sisi"),
            new Person(2626, "Pipi"),
            new Person(2625, "Zizi"),
            new Person(2624, "Fifi"),
            new Person(2623, "Tedi"),
            new Person(2622, "Simi"),
            new Person(2621, "Mimi"),
            };
        }

        [Test]
        public void ConstructorInitializeThePeopleInDataWithExactly16People()
        {
            //Arrange
            extendedDB = new ExtendedDatabase.ExtendedDatabase(people);

            //Assert
            Assert.AreEqual(DatabaseCapacity, extendedDB.Count);
        }

        [Test]
        public void CheckIfArrayIsOverCapacity()
        {
            people = new Person[17];
            //Assert
            Assert.Throws<ArgumentException>(() =>
            new ExtendedDatabase.ExtendedDatabase(people));

        }

        [Test]
        public void ThrowExceptionIfTryToAddMoreThanDatabaseCapacity()
        {
            extendedDB = new ExtendedDatabase.ExtendedDatabase(people);

            //Assert
            Assert.Throws<InvalidOperationException>(()
                => extendedDB.Add(new Person(3698, "Jizi")));
        }
        [Test]
        public void ThrowExceptionIfTryToAddSamePersonWithAlreadyExistingName()
        {
            extendedDB.Add(new Person(2621, "Mimi"));

            Assert.Throws<InvalidOperationException>(() => extendedDB.Add(new Person(7979, "Mimi"))); ;
        }
        [Test]
        public void ThrowExceptionIfTryToAddSamePersonWithAlreadyExistingId()
        {
            extendedDB.Add(new Person(2621, "Mimi"));

            Assert.Throws<InvalidOperationException>(() => extendedDB.Add(new Person(2621, "Jana"))); ;
        }

        [Test]
        public void RemoveOperationShouldReturnException()
        {
            //Arrange
            extendedDB = new ExtendedDatabase.ExtendedDatabase();

            //Assert
            Assert.Throws<InvalidOperationException>(() => extendedDB.Remove());
        }

        [Test]
        public void RemoveShouldRemoveAtLastIndex()
        {
            extendedDB = new ExtendedDatabase.ExtendedDatabase(new Person(26231, "Jino"));

            extendedDB.Remove();

            var expectedCount = 0;
            int actualCount = extendedDB.Count;
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void FindByUserNameShouldReturnMatchingName()
        {
            extendedDB = new ExtendedDatabase.ExtendedDatabase(people);

            Person actualPerson = people[15];
            Person expectedPerson = extendedDB.FindByUsername("Mimi");

            Assert.AreEqual(expectedPerson, actualPerson);
        }
        [Test]
        public void FindByUserNameShouldReturnMatchingNameIsFalse()
        {
            extendedDB = new ExtendedDatabase.ExtendedDatabase(people);

            Person actualPerson = people[15];

            Assert.Throws<InvalidOperationException>(() => extendedDB.FindByUsername("Desi"));
        }
        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void FindByUserNameShouldThrowArgumentNullExceptionWhenTheNameIsNullOrEmpty(string name)
        {
            Assert.Throws<ArgumentNullException>(() => extendedDB.FindByUsername(name));
        }

        [TestCase(-1)]
        public void FindByUserIDShouldThrowArgumentOutOfRangeExceptionWhenTheIdIsLEssThanZero(int Id)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => extendedDB.FindById(Id));
        }

        [TestCase(2646)]
        [TestCase(000000)]
        [TestCase(123313540)]
        public void FindByUserIDShouldThrowInvalidOperationExceptionTheIdDoesntExist(int Id)
        {
            Assert.Throws<InvalidOperationException>(() => extendedDB.FindById(Id));
        }
        [Test]
        public void FindByIdShouldReturnMatchingId()
        {
            extendedDB = new ExtendedDatabase.ExtendedDatabase(people);

            Person actualPerson = people[15];
            Person expectedPerson = extendedDB.FindById(2621);

            Assert.AreEqual(expectedPerson, actualPerson);
        }
    }
}