using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public UIholder player1;
    public UIholder player2;

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    #region Functions for KeyForge Tracking

    public void AddAEmber(bool whichPlayer)
    {
        //true == player 1
        //false == player 2

        if(whichPlayer)
        {
            player1.currentAEmber++;
        }
        else
        {
            player2.currentAEmber++;
        }
    }

    public void RemoveAEmber(bool whichPlayer)
    {
        //true == player 1
        //false == player 2

        if (whichPlayer)
        {
            if (player1.currentAEmber > 0)
            {
                player1.currentAEmber--;
            }
        }
        else
        {
            if (player2.currentAEmber > 0)
            {
                player2.currentAEmber--;
            }
        }
    }

    public void AddChains(bool whichPlayer)
    {
        //true == player 1
        //false == player 2

        if (whichPlayer)
        {
            player1.currentChains++;
            player1.ChangeHandSize(player1.currentChains);
        }
        else
        {
            player2.currentChains++;
            player2.ChangeHandSize(player2.currentChains);
        }

    }

    public void RemoveChains(bool whichPlayer)
    {
        //true == player 1
        //false == player 2

        if (whichPlayer)
        {
            if (player1.currentChains > 0)
            {
                player1.currentChains--;
                player1.ChangeHandSize(player1.currentChains);
            }
        }
        else
        {
            if (player2.currentChains > 0)
            {
                player2.currentChains--;
                player2.ChangeHandSize(player2.currentChains);
            }
        }
    }

    public void AddKeys(bool whichPlayer)
    {
        //true == player 1
        //false == player 2

        if (whichPlayer)
        {
            if (player1.currentAEmber >= player1.keyCost)
            {
                player1.currentKeys++;
                player1.currentAEmber -= player1.keyCost;
            }
        }
        else
        {
            if (player2.currentAEmber >= player1.keyCost)
            {
                player2.currentKeys++;
                player2.currentAEmber -= player2.keyCost;
            }
        }
    }

    public void RemoveKeys(bool whichPlayer)
    {
        //true == player 1
        //false == player 2
        
        if (whichPlayer)
        {
            if (player1.currentKeys > 0)
            {
                player1.currentKeys--;
            }
            
        }
        else
        {
            if (player2.currentKeys > 0)
            {
                player2.currentKeys--;
            }
        }
    }

    public void AddKeyCost(bool whichPlayer)
    {
        //true == player 1
        //false == player 2

        if (whichPlayer)
        {
            player1.keyCost++;
        }
        else
        {
            player2.keyCost++;
        }
    }

    public void RemoveKeyCost(bool whichPlayer)
    {
        //true == player 1
        //false == player 2

        if (whichPlayer)
        {
            if (player1.keyCost > 0)
            {
                player1.keyCost--;
            }
           
        }
        else
        {
            if (player2.keyCost > 0)
            {
                player2.keyCost--;
            }
            
        }
    }

    public void AddTurnCount(bool whichPlayer)
    {
        //true == player 1
        //false == player 2

        if (whichPlayer)
        {
            //Adds up the turn Count
            player1.currentTurnCount++;
            //Reduces amount of Chains if any
            if (player1.currentChains > 0)
            {
                player1.currentChains--;
            }
            //Draw up to Check
            player1.ChangeHandSize(player1.currentChains);
        }
        else
        {
            //Adds up the turn Count
            player2.currentTurnCount++;
            //Reduces amount of Chains if any
            if (player2.currentChains > 0)
            {
                player2.currentChains--;
            }
            //Draw up to Check
            player2.ChangeHandSize(player2.currentChains);
        }
    }

    public void RemoveTurnCount(bool whichPlayer)
    {
        //true == player 1
        //false == player 2

        if (whichPlayer)
        {
            if (player1.currentTurnCount > 0)
            {
                player1.currentTurnCount--;
            }
        }
        else
        {
            if (player2.currentTurnCount > 0)
            {
                player2.currentTurnCount--;
            }
        }
    }

    public void AddHandSize(bool whichPlayer)
    {
        //true == player 1
        //false == player 2

        if (whichPlayer)
        {
            player1.currentHandSize++;
        }
        else
        {
            player2.currentHandSize++;
        }
    }

    public void RemoveHandSize(bool whichPlayer)
    {
        //true == player 1
        //false == player 2

        if (whichPlayer)
        {
            if (player1.currentHandSize > 0)
            {
                player1.currentHandSize--;
            }
        }
        else
        {
            if (player2.currentHandSize > 0)
            {
                player2.currentHandSize--;
            }
        }
    }

    public void ResetInfo1Player()
    {
        player1.FullReset();
    }

    public void ResetInfo2Player()
    {
        player1.FullReset();
        player2.FullReset();
    }
    #endregion
}
