using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//REMEMBER: the trigger on the box collider for the arrow is checked. This will let us know when the arrow has gone within the bow.

public class Arrow : MonoBehaviour {

    void OnTriggerEnter()
    {
        Debug.Log("Entered Bow"); // This is to test the trigger
    }
}
