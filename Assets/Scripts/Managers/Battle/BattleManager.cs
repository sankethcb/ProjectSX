﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BattleManager : MonoBehaviour
{

    GameObject PlayerManager;
    GameObject EnemyManager;

    public GameObject[] PlayerParty;
    public GameObject[] EnemyParty;

    GameObject[] PlayerGrid;
    GameObject[] EnemyGrid;

   public List<GameObject> TurnOrder;

    Unit[] PlayerUnits;
    Unit[] EnemyUnits;

    public int characterCount;

    void Start ()
    {
        PlayerManager = GameObject.FindGameObjectWithTag("PlayerManager");
        EnemyManager = GameObject.FindGameObjectWithTag("EnemyParty");

        PlayerParty = PlayerManager.GetComponent<PartyManager>().PlayerParty;
        EnemyParty = EnemyManager.GetComponent<EnemyParty>().Party;

        PlayerGrid = GameObject.FindGameObjectsWithTag("PlayerUnit");
        EnemyGrid = GameObject.FindGameObjectsWithTag("EnemyUnit");

        PlayerUnits = new Unit[6];
        EnemyUnits = new Unit[6];

        TurnOrder = new List<GameObject>();

        characterCount = PlayerManager.GetComponent<PartyManager>().count+ EnemyManager.GetComponent<EnemyParty>().count;
       
        Battle();

    }

	public void Battle()
    {

        BattleSetUp();
        PlayerTurn();
        EnemyTurn();
    }

    void PlayerTurn()
    {

    }

    void EnemyTurn()
    {

    }

    void BattleSetUp()
    {
        SetUnits();
        SetUpPlayer();
        SetUpEnemy();
        SetTurnOrder();
    }

    void SetUnits()
    {
        for(int i=1;i<=6;i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (PlayerGrid[j].GetComponent<Unit>().UnitNumber == i)
                    PlayerUnits[i - 1] = PlayerGrid[j].GetComponent<Unit>();

                if (EnemyGrid[j].GetComponent<Unit>().UnitNumber == i)
                    EnemyUnits[i - 1] = EnemyGrid[j].GetComponent<Unit>();
            }
        }
    }

    void SetUpPlayer()
    {
        PlayerUnits[0].SetChar(PlayerParty[0]);
        PlayerUnits[1].SetChar(PlayerParty[1]);
    }

    void SetUpEnemy()
    {
        EnemyUnits[0].SetChar(EnemyParty[0]);
        EnemyUnits[1].SetChar(EnemyParty[1]);
    }

    void SetTurnOrder()
    {
        int hAgility=0;
        GameObject temp;
        

        for(int i=0; i <characterCount;i++)
        {
            hAgility = PlayerParty[0].GetComponent<Player>().Agility;
           
            if (PlayerParty[i] != null)
                TurnOrder.Add(PlayerParty[i]);

            if (EnemyParty[i] != null)
                TurnOrder.Add(EnemyParty[i]);

        }

       

    }
	
}
