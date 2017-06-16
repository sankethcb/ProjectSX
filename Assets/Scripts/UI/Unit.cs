using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Unit : MonoBehaviour {


    bool isActive;
    public int UnitNumber;
    GameObject current;
    Image displaySprite;
    EventTrigger eventHandler;

	void Awake ()
    {
        displaySprite = GetComponent<Image>();

	}
	
	

    public void SetChar(GameObject character)
    {
        current = character;
        isActive = true;
         SetSprite();
    }

    public void RemoveChar()
    {
        current = null;
        isActive = false;
        RemoveSprite();
    }

    void SetSprite()
    {
        if (current.tag == "Player")
            displaySprite.sprite = current.GetComponent<Player>().MySprite;
        else
            displaySprite.sprite = current.GetComponent<BaseEnemy>().MySprite;
    }

    void RemoveSprite()
    {
        displaySprite.sprite = null;
    }
}
