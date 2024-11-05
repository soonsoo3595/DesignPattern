using UnityEngine;

namespace FlyweightPattern
{
    public class MonsterType : IMonster
    {
        private int ID;
        private string type;

        public MonsterType(int ID, string type)
        {
            this.ID = ID;
            this.type = type;
        }

        public void Attack(int x, int y)
        {
            Debug.Log("MonsterType: " + type + " is attacking from " + x + ", " + y);
        }
    }
}