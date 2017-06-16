using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : Character {


    List<GameObject> GearSet;
    IRaceInterface PlayerRace;
    float baseDmg;
   
    double cHP;
    void Start ()
    {
        Level = 1;
        IsPlayer = true;
        PlayerRace = GetComponent<IRaceInterface>();
        PlayerRace.BaseStats(this);
        baseDmg = 10;
	}

    public void Attack()
    {

    }

    public void TakeDamage()
    {

    }


}
