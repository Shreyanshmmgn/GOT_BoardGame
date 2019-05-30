using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaster : MonoBehaviour
{
    // Start is called before the first frame update
    public bool moveNow;
    public int NumberOfStepsToMove;
    public PathobjectParent pathsparent;
    private void Awake(){
        pathsparent= FindObjectOfType<PathobjectParent>();
    
    }
}
