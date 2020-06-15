using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour {

    public bool DetectKey; //Allows for the key to be collected
    public bool DetectCoin; //Allows for the coin to be collected
    public bool DetectDoor; //Will be true if the player is at the door at the end of the maze
    public bool DetectSign; //Yada yada yada sign post
    
	// Use this for initialization
	void Start ()
    {
        DetectKey   = false;
        DetectCoin  = false;
        DetectDoor  = false;
        DetectSign  = false;
   
	}

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;

        if (Physics.Raycast(transform.position, fwd, out hit, 5))
        {
            if (hit.collider.CompareTag("Key"))
            {
                DetectKey = true;
            }
            
            if (hit.collider.CompareTag("Coin"))
            {
                DetectCoin = true;
            }

            if (hit.collider.CompareTag("Door"))
            {
                DetectDoor = true;
            }

            if (hit.collider.CompareTag("SignPost"))
            {
                DetectSign = true;
            }

        }

    }
}
