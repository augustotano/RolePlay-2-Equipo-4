using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class SpellsBookTest
    {
        private SpellsBook spellsBook
        ;
         [SetUp]
        public void SetUp()
        {
           spellsBook = new SpellsBook();
           spellsBook.Spells[0]=new Spell();
           spellsBook.Spells[1]=new Spell();
           spellsBook.Spells[2]=new Spell();
        }

        [Test]
        public void TestAttackValue()
        {
            Assert.AreEqual(spellsBook.AttackValue,210);
        }

        [Test]
        public void TestDefenseValue()
        {
             Assert.AreEqual(spellsBook.DefenseValue,210);
        }
    }
}
