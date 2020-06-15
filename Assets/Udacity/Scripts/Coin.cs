using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    public GameObject CoinObject;
    public GameObject CoinPoof;
    DetectObject detectCoin; // I will use this to get the state of the DetectCoin bool used in the DetectObject script
    //public int CoinCount = 0; // This will be true when the first coin is picked up

    void Start()
    {
        CoinPoof.SetActive(false);       
    }

    void Update()
    {
        detectCoin = GameObject.FindWithTag("MainCamera").GetComponent<DetectObject>(); // This will give me the state of DetectCoin from the DetectObject script
        
    }
    public void OnCoinClicked()
    {
        if (detectCoin.DetectCoin == true)
        {
            Object.Destroy(gameObject); // Destroys the coin
            CoinPoof.SetActive(true); // Activates the coin poof 
            //++CoinCount; //Adds 1 to CoinCount
        }
    }
}
