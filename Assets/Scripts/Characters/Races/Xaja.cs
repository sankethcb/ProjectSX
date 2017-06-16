﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xaja :Race,IRaceInterface
{
   

    void Start()
    {
        Type = "Xaja Warrior";
        Size = 1;
        BaseHP = 150;
    }

    public void BaseStats(Player player)
    {
        player.BaseHP = BaseHP;
        player.Size = Size;
    }


}