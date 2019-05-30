using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerMaster[] players;
    public bool[] began;
    public int currentPlayer = 0;
    public static GameManager gm;
    public int stepsToMove;
    private void Awake()
    {
        // SINGLETON
        gm = this;
    }
    private void Start()
    {   
        began = new bool[players.Length];
        for (int i = 0; i < began.Length; i++)
        {
            began[i] = false;
        }
    }
    public void MasterMove()
    {
        players[currentPlayer].MoveSteps();
    }
}
