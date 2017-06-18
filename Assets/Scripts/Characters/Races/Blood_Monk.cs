using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood_Monk : Race, IRaceInterface
{

	
	void Awake()
    {
        Type = "Blood Monk";
        Size = 1;
        BaseHP = 100;
        Threat = 1;
        
	}

    public void BaseStats(Player player)
    {
        player.BaseHP = BaseHP;
        player.Size = Size;
        player.Threat = Threat;

    }
}
