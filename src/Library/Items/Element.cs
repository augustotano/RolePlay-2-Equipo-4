namespace RoleplayGame
{
    public abstract class Element
    {
        protected int attackValue = 0;
        protected int defenseValue = 0;

        public virtual int AttackValue {get;}
        public virtual int DefenseValue {get;}
    }
}