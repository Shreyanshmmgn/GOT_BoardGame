using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaster : MonoBehaviour
{   public bool canMove;
    public bool moveNow;
    public int NumberOfStepsToMove;
    public PathobjectParent pathsparent;
    private void Awake(){
        pathsparent= FindObjectOfType<PathobjectParent>();
    
    }
     private void OnMouseDown()
    {
        canMove = true;
        Debug.Log(this.gameObject.name);
        StartCoroutine("MoveStepsEnum");
    }
}
