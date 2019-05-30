using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public int numberGot;
    public SpriteRenderer DiceHolder;
    public Sprite[] diceno;
    
    private void OnMouseDown()
    {       Debug.Log("Inside dice");
            numberGot = Random.Range(0, 6);
            DiceHolder.sprite = diceno[numberGot];
            numberGot += 1;   
    }
}
