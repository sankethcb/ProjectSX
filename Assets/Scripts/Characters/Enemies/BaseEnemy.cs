using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : Character {


    IEnemyInterface eType;
    float baseDmg;

    void Awake()
    {
        eType = GetComponent<IEnemyInterface>();
        eType.BaseStats(this);
        baseDmg = 10;
        Agility = 1;
	}

    public void Attack()
    {

    }

    public void TakeDamage()
    {

    }
	
	
}
