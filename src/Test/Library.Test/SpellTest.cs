using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class SpellTests
    {
        private Spell spell;
         [SetUp]
        public void SetUp()
        {
            spell = new Spell();
        }

         [Test]
        public void TestAttackValue()
        {
            Assert.AreEqual(spell.AttackValue,70);
        }
        [Test]
        public void TestDefenseValue()
        {
            Assert.AreEqual(spell.DefenseValue,70);
        }
    }
}