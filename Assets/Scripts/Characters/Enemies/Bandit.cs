using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandit : EnemyType,IEnemyInterface
{
   
    void Start ()
    {
        BaseHP = 100;
        Size = 1;
	}

    public void BaseStats(BaseEnemy enemy)
    {
        enemy.BaseHP = BaseHP;
        enemy.Size = Size;
    }


}
