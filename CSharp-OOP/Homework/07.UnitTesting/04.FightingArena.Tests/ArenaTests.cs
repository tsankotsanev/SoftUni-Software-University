using NUnit.Framework;
using System;
using System.Collections.Generic;
namespace Tests
{
    [TestFixture]
    public class ArenaTests
    {
        private Warrior warrior;
        private Arena arena;

        [SetUp]
        public void Setup()
        {
            arena = new Arena();
        }

        [Test]
        public void EnrollShouldEnrollWarriorCorrectly()
        {
            Warrior firstWarrior = new Warrior("Django", 10, 150);
            Warrior secondWarrior = new Warrior("Djeni", 10, 150);

            List<Warrior> expectedWarriors = new List<Warrior> { firstWarrior, secondWarrior };

            arena.Enroll(firstWarrior);
            arena.Enroll(secondWarrior);

            Assert.AreEqual(expectedWarriors, arena.Warriors);
        }

        [TestCase("Django", 50, 100)]
        public void TryToEnrollExistingWarriorThrowException(string name, int damage, int Hp)
        {
            //Arrange & Act
            Warrior warrior = new Warrior(name, damage, Hp);
            arena.Enroll(warrior);

            //Assert
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));
        }

        [TestCase("Django", 50, 100)]
        public void EnrollShouldAddWarrior(string name, int damage, int Hp)
        {
            Warrior warrior = new Warrior(name, damage, Hp);
            arena.Enroll(warrior);

            var expectedCount = 1;
            Assert.AreEqual(expectedCount, arena.Count);
        }

        [TestCase("Django", "Deina")]
        public void FightOperationShouldThrowExceptionIfTheWarriorsAreNotExist(string attackerName, string defenderName)
        {
            Warrior warrior = new Warrior("attackerName", 10, 150);

            Assert.Throws<InvalidOperationException>(() => arena.Fight(attackerName, defenderName));
        }

        [TestCase("Django", "Deina")]
        public void FightOperationShouldMadeAttack(string attackerName, string defenderName)
        {
            Warrior firtWarrior = new Warrior(attackerName, 10, 150);
            Warrior secondWarror = new Warrior(defenderName, 5, 250);

            arena.Enroll(firtWarrior);
            arena.Enroll(secondWarror);

            int expected = firtWarrior.HP - secondWarror.Damage;
            arena.Fight(attackerName, defenderName);

            Assert.AreEqual(expected, firtWarrior.HP);
        }
    }
}
