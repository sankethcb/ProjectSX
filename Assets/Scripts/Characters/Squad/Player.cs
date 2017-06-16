using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : Character
{


    List<GameObject> GearSet;
    IRaceInterface PlayerRace;
    public int Threat { get; set; }
    float baseDmg;
    double cHP;
    void Start ()
    {
        Level = 1;
        IsPlayer = true;
        PlayerRace = GetComponent<IRaceInterface>();
        PlayerRace.BaseStats(this);
        baseDmg = 10;
        Agility = 2;
	}

    public void Attack()
    {

    }

    public void TakeDamage()
    {

    }


}
