using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xaja :Race,IRaceInterface
{
   

    void Awake()
    {
        Type = "Xaja Warrior";
        Size = 1;
        BaseHP = 150;
        Threat = 2;
    }

    public void BaseStats(Player player)
    {
        player.BaseHP = BaseHP;
        player.Size = Size;
        player.Threat = Threat;
    }


}
