using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1Player :  PlayerMaster
{


     void Start()
    {
        Debug.Log("inside Start");
        MoveSteps();
        //  StartCoroutine("MoveStepsEnum");
    }
   
    public void MoveSteps()
    {
        for (int i = 0; i < 3; i++)
        {Debug.Log("inside MOve steps");
            transform.position = pathsparent.CommonPath[i].transform.position;
        }
    }
    IEnumerator MoveStepsEnum()
    {
        for (int i = 0; i < 3; i++)
        {
            transform.position = pathsparent.CommonPath[i].transform.position;
            yield return new WaitForSeconds(1f);
        }
    }

  
}
