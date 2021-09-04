using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private Database.Database database;
        private readonly int[] initialData = new int[] { 1, 2, };

        [SetUp]
        public void SetUp()
        {
            database = new Database.Database(initialData);
        }

        [Test]
        public void TestIfConstructorsWorkCorrectly()
        {
            var data = new int[] { 1, 2, 3 };
            database = new Database.Database(data);

            var expectedCount = data.Length;
            int actualCOunt = database.Count;

            Assert.AreEqual(expectedCount, actualCOunt);
        }

        [TestCase(new int[]  { 1, 2, 3, 4, 5,
                             6, 7, 8, 9, 10, 11,
                             12,13,14,15,16,17})]
        public void CheckIfConstructorThrowException(int[] data)
        {
            Assert.Throws<InvalidOperationException>(()
                => database = new Database.Database(data));
        }

        [Test]
        public void AddShouldIncreaseCount()
        {
            //Act
            database.Add(3);
            var expectedCount = 3;
            int actualCount = database.Count;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void AddShouldThrowExceptionWhenDatabaseIsFull()
        {
            //Arrange
            for (var i = 3; i <= 16; i++)
            {
                database.Add(i);
            }

            //Assert
            Assert.Throws<InvalidOperationException>(()
                => database.Add(17));

        }

        [Test]
        public void RemoveShouldDecreaseCountWheSuccess()
        {
            //Act
            database.Remove();

            //Arrange 
            var expected = 1;
            int actualCount = database.Count;

            //Assert
            Assert.AreEqual(expected, actualCount);

        }

        [Test]
        public void RemoveShouldThrowExceptionIfDataBecomesZeroCount()
        {
            database.Remove();
            database.Remove();

            //Assert
            Assert.Throws<InvalidOperationException>(()
                => database.Remove());
        }

        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(new int[] { })]
        public void FetchShouldReturnCopyOfData(int[] expectedData)
        {
            database = new Database.Database(expectedData);

            int[] actualData = database.Fetch();

            CollectionAssert.AreEqual(expectedData, actualData);
        }
    }
}