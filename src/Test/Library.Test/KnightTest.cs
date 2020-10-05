using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class KnightTests
    {
        Knight knight = new Knight("Knight");

        [SetUp]
        public void Setup()
        {
            Sword sword = new Sword();
            knight.Sword = sword;
            Shield shield = new Shield();
            knight.Shield = shield;
            Armor armor = new Armor();
            knight.Armor = armor;
        }

        [Test]
        public void TestKnightName()
        {
            Assert.AreEqual(knight.Name, "Knight");
        }

        [Test]
        public void TestHealth()
        {
            knight.ReceiveAttack(101);
            Assert.AreEqual(knight.Health,38);
        }

        [Test]
        public void TestCure()
        {
            knight.ReceiveAttack(101);
            knight.Cure();
            Assert.AreEqual(knight.Health,100);
        }

        [Test]
        public void TestHealthAlive()
        {
            knight.ReceiveAttack(10);
            Assert.AreEqual(knight.Health,38);
        }
        
        [Test]
        public void TestReciveAttack()
        {
            Dwarf dwarf = new Dwarf("Dwarf");
            Axe axe = new Axe();
            Shield shield = new Shield();
            Helmet helmet = new Helmet();
            dwarf.Axe = axe;
            dwarf.Helmet = helmet;
            dwarf.Shield = shield;
            knight.ReceiveAttack(dwarf.AttackValue);
            Assert.AreEqual(knight.Health,38);
        }
    }
}