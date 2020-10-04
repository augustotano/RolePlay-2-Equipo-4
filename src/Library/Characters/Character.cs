namespace RoleplayGame
{
    public abstract class Character
    {
        protected int health = 100;

        public Character(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public virtual int AttackValue { get;}

        public virtual int DefenseValue { get;}

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}