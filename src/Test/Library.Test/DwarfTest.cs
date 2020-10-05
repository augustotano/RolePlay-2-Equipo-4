using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class DwarfTests
    {
        Dwarf dwarf = new Dwarf("Dwarf");

        [SetUp]
        public void Setup()
        {
            Shield shield = new Shield();
            dwarf.Shield = shield;
            Helmet helmet = new Helmet();
            dwarf.Helmet = helmet;
            Axe axe = new Axe();
            dwarf.Axe = axe;
        }

        [Test]
        public void TestDwarfName()
        {
            Assert.AreEqual(dwarf.Name,"Dwarf");
        }

        [Test]
        public void TestHealth()
        {
            dwarf.ReceiveAttack(101);
            Assert.AreEqual(dwarf.Health,31);
        }

        [Test]
        public void TestCure()
        {
            dwarf.ReceiveAttack(101);
            dwarf.Cure();
            Assert.AreEqual(dwarf.Health,100);
        }

        [Test]
        public void TestHealthAlive()
        {
            dwarf.ReceiveAttack(10);
            Assert.AreEqual(dwarf.Health,31);
        }
        
        [Test]
        public void TestReciveAttack()
        {
            Knight knight = new Knight("Knight");
            Sword sword = new Sword();
            knight.Sword = sword;
            dwarf.ReceiveAttack(knight.AttackValue);
            Assert.AreEqual(dwarf.Health,31);
        }
    }
}