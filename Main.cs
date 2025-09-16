using NUnit.Framework;

using System.Collections.Generic;

using UnityEngine;

public class Main : MonoBehaviour
{
    public Hero hero;
    public List<Monster> monstersPrefabs;
    public Monster currenMonster;
    public List<Monster> monsters = new List<Monster>();

    void Start()
    {
        hero.Init("VIG", 20, 10);

        hero.ShowStat();

        currenMonster = Instantiate(monstersPrefabs[0]);
        currenMonster.Init("Orc", 20, 10, 100);
        currenMonster.ShowStat();

        currenMonster = Instantiate(monstersPrefabs[1]);
        currenMonster.Init("Orc2", 20, 10, 100);
        currenMonster.ShowStat();

        currenMonster = Instantiate(monstersPrefabs[2]);
        currenMonster.Init("Orc3", 20, 10, 100);
        currenMonster.ShowStat();
        monsters.Add(currenMonster);
    }
}


    
