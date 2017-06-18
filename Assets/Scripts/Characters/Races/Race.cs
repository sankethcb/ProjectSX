using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Race : MonoBehaviour {

    public string Type { get; protected set; }
    public int BaseHP { get; protected set; }
    public int Size { get; protected set; }
    public int Threat { get; protected set; }

    void Awake()
    {
        Type = "none";
        Size = 1;
        Threat = 1;
	}
	
	
}
