using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject KeyObject;
    public GameObject KeyPoof;
    public bool GotKey;                         // This will be true when the key is picked up
    DetectObject detectKey;                     // I will use this to get the state of the DetectKey bool used in the DetectObject script

    void Start()
    {
        KeyPoof.SetActive(false);
        GotKey = false;                         // Sets state as false to indicate the key has not been picked up
    }

    void Update()
	{
        detectKey = GameObject.FindWithTag("MainCamera").GetComponent<DetectObject>(); // This will give me the state of DetectKey from the DetectObject script
    }

    public void OnKeyClicked()
	{
               if (detectKey.DetectKey == true)
        {
            Object.Destroy(gameObject); // Destroys the coin
            KeyPoof.SetActive(true); // Activates the coin poof 
            GotKey = true; //Sets state of got coin to true to indicate the coin has been picked up
        }
    }

}
