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
    private double bHP;
    public int Size
    {
        get { return Size; }
        set
        {
            if (value > 0)
                Size = value;
        }
    }
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

    public double CHP
    {
        get
        {
            return CHP;
        }
        set
        {
            if (value > 0)
                CHP = value;
            else
            {
                CHP = 0;
                isDead = true;
            }
        }
    }
    public bool isDead { get; private set; }
    public bool IsPlayer { get; protected set; }
    public Sprite MySprite;
    
    #endregion

    #region Character Methods
    private void Start()
    {
        Name = "default";
        Level = 1;
        Size = 1;
        isDead = true;
    }

    
    #endregion
}
