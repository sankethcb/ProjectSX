using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParty : MonoBehaviour {

    public GameObject[] Party;

    public GameObject b1;
    public GameObject b2;
    // Use this for initialization
    void Awake ()
    {
        Party = new GameObject[6];
        SetParty();

	}



    void SetParty()
    {
        Party[0] = Instantiate(b1); 
        Party[1] = Instantiate(b2);
    }
}
