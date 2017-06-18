using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BattleManager : MonoBehaviour
{

    GameObject PlayerManager;
    GameObject EnemyManager;

    GameObject[] PlayerParty;
   GameObject[] EnemyParty;

    GameObject[] PlayerGrid;
    GameObject[] EnemyGrid;

   public List<GameObject> TurnOrder;

    Unit[] PlayerUnits;
    Unit[] EnemyUnits;

    int characterCount;

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
        int hChar = 0;
        GameObject temp;
     

        for(int j=0;j<6;j++)
        {
            if(PlayerParty[j] != null)
                TurnOrder.Add(PlayerParty[j]);
            if(EnemyParty[j] != null)
                TurnOrder.Add(EnemyParty[j]);

        }
        
        
        for (int i=0; i <characterCount;i++)
        {
            hAgility = 0;
            hChar = 0;
            for (int k=i;k<characterCount;k++)
            {

                if(TurnOrder[k].GetComponent<Player>()!=null)
                {
                    if(TurnOrder[k].GetComponent<Player>().Agility>hAgility)
                    {
                        hChar = k;
                        hAgility = TurnOrder[k].GetComponent<Player>().Agility;

                        

                    }
                   

                }
                else if (TurnOrder[k].GetComponent<BaseEnemy>() != null)
                {
                    if (TurnOrder[k].GetComponent<BaseEnemy>().Agility > hAgility)
                    {
                        hChar = k;
                        hAgility = TurnOrder[k].GetComponent<BaseEnemy>().Agility;
                        
                    }
                   
                }
               
            }

            temp = TurnOrder[i];
            TurnOrder[i] = TurnOrder[hChar];
            TurnOrder[hChar] = temp;

        }
     
       

    }
	
}
