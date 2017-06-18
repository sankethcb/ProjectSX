using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParty : MonoBehaviour {

    public GameObject[] Party;
    public int count { get; private set;}
    public GameObject bandit;

    // Use this for initialization
    void Awake ()
    {
        Party = new GameObject[6];
        SetParty();

	}



    void SetParty()
    {
        Party[0] = Instantiate(bandit); 
        Party[1] = Instantiate(bandit);
        count = 2;
    }
}
