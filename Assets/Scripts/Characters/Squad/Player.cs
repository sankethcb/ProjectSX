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


    void Awake ()
    {
        Level = 1;
        PlayerRace = GetComponent<IRaceInterface>();
        baseDmg = 10;
        Agility = 2;
        PlayerRace.BaseStats(this);
       
        

    }

    public void Attack()
    {

    }

    public void TakeDamage()
    {

    }


}
