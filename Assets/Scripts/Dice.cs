using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{   
    public int numberGot;
    public SpriteRenderer DiceHolder;
    public Sprite[] diceno;
  
    private void OnMouseDown()
    {    
        numberGot = Random.Range(0, 6);
        DiceHolder.sprite = diceno[numberGot];
        numberGot += 1;   
        GameManager.gm.stepsToMove = numberGot;
        // Done:
        // Tell auto move to move
        if(GameManager.gm.began[GameManager.gm.currentPlayer] == false)
        {
            if(numberGot == 1){
                GameManager.gm.began[GameManager.gm.currentPlayer] = true;
                GameManager.gm.MasterMove();
                GameManager.gm.currentPlayer = (GameManager.gm.currentPlayer + 1) % GameManager.gm.players.Length;
            }
            else if(numberGot == 6){
                GameManager.gm.began[GameManager.gm.currentPlayer] = true;
                GameManager.gm.MasterMove();
            }
            else{
                GameManager.gm.currentPlayer = (GameManager.gm.currentPlayer + 1) % GameManager.gm.players.Length;
            }
        }
        else{
            if(numberGot == 6){
                GameManager.gm.MasterMove();
            }
            else{
                GameManager.gm.MasterMove();
                GameManager.gm.currentPlayer = (GameManager.gm.currentPlayer + 1) % GameManager.gm.players.Length;
            }
        }
    }
}
