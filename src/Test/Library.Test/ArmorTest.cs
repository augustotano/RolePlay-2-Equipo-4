using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class ArmorTest
    {
        private Armor armor;
         [SetUp]
        public void SetUp()
        {
            armor = new Armor();
        }
        
        [Test]
        public void TestDefenseValue()
        {
            Assert.AreEqual(armor.DefenseValue,25);
        }
    }
}