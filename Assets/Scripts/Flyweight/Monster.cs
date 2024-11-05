namespace FlyweightPattern
{
    public class Monster
    {
        private int x;
        private int y;
        private MonsterType monsterType;

        public Monster(int x, int y, MonsterType monsterType)
        {
            this.x = x;
            this.y = y;
            this.monsterType = monsterType;
        }

        public void Attack()
        {
            monsterType.Attack(x, y);
        }
    }
}