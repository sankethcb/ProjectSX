using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gear : MonoBehaviour
{
    #region Gear Members
    public string Name { get; protected set; }
    public int Level { get; protected set; }
    
    enum GearType {Body,Helm,Gloves,Boots,Gadget,Throwable}

    private GearType Type;
    #endregion

    #region Gear Methods
    private void Start()
    {
        Name = "default";
        Level = 0;
 
    }
    #endregion
}
