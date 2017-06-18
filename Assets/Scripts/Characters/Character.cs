using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Sanketh Bhat
/// </summary>
public abstract class Character : MonoBehaviour
{

    #region Character Members
    public string Name { get; protected set; }
    public int Level { get; protected set; }

    private int agility;
    public int Agility
    {
        get { return agility; }
        set
        {
            if (value >=0)
                agility = value;
        }
    }

    private int size;
    public int Size
    {
        get { return size; }
        set
        {
            if (value > 0)
                size = value;
        }
    }

    private double bHP;
    public double BaseHP
    {
        get { return bHP;}
        set
        {
            bHP = value;
            if (bHP < 0)
                bHP = 0;

        }
    }

    private float cHP;
    public float CHP
    {
        get
        {
            return cHP;
        }
        set
        {
            if (value > 0)
                cHP = value;
            else
            {
                cHP = 0;
                isDead = true;
            }
        }
    }

    public bool isDead { get; private set; }


    public Sprite MySprite;
    
    #endregion

    #region Character Methods
    private void Awake()
    {
        Name = "default";
        Level = 1;
        Size = 1;
        isDead = true;
    }

    
    #endregion
}
