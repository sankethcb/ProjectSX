using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyManager : MonoBehaviour {

    List<GameObject> Squad;
    public GameObject[] PlayerParty;

    public GameObject bm;
    public GameObject xw;


    public int count { get; private set; }

    void Awake ()
    {
        Squad = new List<GameObject>();
        PlayerParty = new GameObject[6];

        Create();
        SetParty();
        
    }

    void Create() 
    {
        Squad.Add(Instantiate(bm));
        Squad.Add(Instantiate(xw));

    }
	
    void SetParty()
    {
        PlayerParty[0] = Squad[0];
        PlayerParty[1] = Squad[1];
        count = 2;
    }
	
}
