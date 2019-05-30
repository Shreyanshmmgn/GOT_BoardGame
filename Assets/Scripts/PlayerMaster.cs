using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaster : MonoBehaviour
{
    
    public PathobjectParent pathsparent;

    Coroutine moveSteps_Coroutine;
    public bool canMove = true;
    int postionToGO;
    int startingPostion = 0;
    private void Awake()
    {
        pathsparent = FindObjectOfType<PathobjectParent>();

    }

    public void MoveSteps()
    {
        moveSteps_Coroutine = StartCoroutine(MoveStepsEnum());
    }
    IEnumerator MoveStepsEnum()
    {   
        postionToGO = GameManager.gm.stepsToMove;
        if (canMove)
        {
            for (int i = 0; i < postionToGO; i++)
            {
                int position = (startingPostion + i) % 28;
                transform.position = pathsparent.CommonPath[position].transform.position;
                yield return new WaitForSeconds(1f);
              
            }
            startingPostion = startingPostion + postionToGO;
            Debug.Log("New Starting Position" + startingPostion);
        }
        if (moveSteps_Coroutine != null)
        {
            StopCoroutine(moveSteps_Coroutine);
        }
    }
}
