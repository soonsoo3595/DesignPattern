using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern
{
    public class MonsterSpawner
    {
        private Dictionary<int, MonsterType> monsterTypes = new Dictionary<int, MonsterType>();

        public MonsterType GetMonsterType(int ID, string type)
        {
            if (monsterTypes.ContainsKey(ID) == false)
            {
                Debug.Log("MonsterType: " + type + " is created");
                monsterTypes[ID] = new MonsterType(ID, type);
            }
        
            return monsterTypes[ID];
        }
    }
}

