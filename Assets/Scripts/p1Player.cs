using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1Player : PlayerMaster
{
    public Dice move;
    int postionToGO;
    int startingPostion = 0;
    void Start()
    {

    }
    private void OnMouseDown()
    {
        canMove = true;
        Debug.Log(this.gameObject.name);
        StartCoroutine("MoveStepsEnum");

    }

    public void MoveSteps()
    {
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("inside MOve steps");
            transform.position = pathsparent.CommonPath[i].transform.position;
        }
    }
    IEnumerator MoveStepsEnum()
    {    // {   yield return new WaitForSeconds(.5f);
        postionToGO = move.numberGot;
        Debug.Log("Postion to GO" + move.numberGot);
        if (canMove)
        {
            
            for (int i = 0; i < postionToGO; i++)
            {   
                int position=(startingPostion+i)%28;
                transform.position = pathsparent.CommonPath[position].transform.position;
                yield return new WaitForSeconds(1f);
                // postionToGO = move.numberGot;
            }
            startingPostion = startingPostion + postionToGO;
            Debug.Log("New Starting Position" + startingPostion);
        }
    }


}
