/*
 * I am legend
 * 
 * This script is the player information holder, part of the player UI prefab
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIholder : MonoBehaviour {

    //public bool turnCheck = false;

    public int playerNum;

    public int currentAEmber = 0;
    public int currentChains = 0;
    public int currentKeys = 0;
    public int keyCost = 6;
    public int currentTurnCount = 0;
    public int currentHandSize = 6;

    public Text playerNumText;
    public Text aEmberText;
    public Text chainsText;
    public Text keysText;
    public Text keyCostText;
    public Text turnCountText;
    public Text handSizeText;

    private void Start()
    {
        playerNumText.text = "PLAYER " + playerNum;
    }

    private void Update()
    {
        aEmberText.text = currentAEmber.ToString();
        chainsText.text = currentChains.ToString();
        keysText.text = currentKeys.ToString();
        keyCostText.text = keyCost.ToString();
        turnCountText.text = currentTurnCount.ToString();
        handSizeText.text = currentHandSize.ToString();
       
    }

    public void ChangeHandSize(int i)
    {
        //Starts at the lowest and goes up
        int temp = 2;

        if(i == 0)
        {
            temp = 6;
        }
        else if(i<=6)
        {
             temp = 5;
        }
        else if (i <= 12)
        {
            temp = 4;
        }
        else if (i <= 18)
        {
            temp = 3;
        }
        else if (i <= 24)
        {
            temp = 2;
        }
        else
        {
            currentChains = 24;
        }

        currentHandSize = temp;
        
    }

    public void FullReset()
    {
        currentAEmber = 0;
        currentChains = 0;
        currentKeys = 0;
        keyCost = 6;
        currentTurnCount = 0;
        currentHandSize = 6;

        //This resets a check currently for hand size
        //turnCheck = false;
    }
}
