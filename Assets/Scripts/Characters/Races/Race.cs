using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Race : MonoBehaviour {

    public string Type { get; protected set; }
    public int BaseHP { get; protected set; }
    public int Size { get; protected set; }
    
    void Start ()
    {
        Type = "none";
        Size = 1;
	}
	
	
}
