using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class ArcherTests
    {
        
        Archer archer = new Archer("Archer");

        [SetUp]
        public void Setup()
        {
            Bow bow = new Bow();
            archer.Bow = bow;
            Helmet helmet = new Helmet();
            archer.Helmet = helmet;
        }

        [Test]
        public void TestArcherName()
        {
            Assert.AreEqual(archer.Name,"Archer");
        }

        [Test]
        public void TestHealth()
        {
            archer.ReceiveAttack(101);
            Assert.AreEqual(archer.Health,17);
        }

        [Test]
        public void TestCure()
        {
            archer.ReceiveAttack(101);
            archer.Cure();
            Assert.AreEqual(archer.Health,100);
        }

        [Test]
        public void TestHealthAlive()
        {
            archer.ReceiveAttack(10);
            Assert.AreEqual(archer.Health,17);
        }
        
        [Test]
        public void TestReciveAttack()
        {
            Knight knight = new Knight("Knight");
            Sword sword = new Sword();
            knight.Sword = sword;
            archer.ReceiveAttack(knight.AttackValue);
            Assert.AreEqual(archer.Health,15);
        }
    }
}