using UnityEngine;

namespace FlyweightPattern
{
    public class Game : MonoBehaviour
    {
        MonsterSpawner monsterSpawner = new MonsterSpawner();

        void Awake()
        {
            for (int i = 0; i < 10; i++)
            {
                monsterSpawner.GetMonsterType(i, $"Monster {i}");
            }
        }
        
        void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                Monster monster = new Monster(Random.Range(0, 10), Random.Range(0, 10), monsterSpawner.GetMonsterType(i, $"Monster {i}"));
                monster.Attack();
            }

            Monster newMonster = new Monster(10, 10, monsterSpawner.GetMonsterType(10, $"Boss"));
            newMonster.Attack();
        }
    }

}
