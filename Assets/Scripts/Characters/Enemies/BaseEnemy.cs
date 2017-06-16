using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : Character {


    IEnemyInterface eType;
    float baseDmg;
    double cHP;

    void Start ()
    {
        IsPlayer = false;
        eType = GetComponent<IEnemyInterface>();
        eType.BaseStats(this);
        baseDmg = 10;
	}

    public void Attack()
    {

    }

    public void TakeDamage()
    {

    }
	
	
}
