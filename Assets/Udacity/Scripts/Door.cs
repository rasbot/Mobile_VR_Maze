using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    public GameObject OpenDoor;
    public string AnimationName;
    public Animator StateMachine;
    public bool Locked = true;
    DetectObject detectDoor; // I will use this to get the state of the DetectDoor bool used in the DetectObject script
    Key key; // I need to find out if the player has the key!
    public AudioClip[] soundFiles;
    public AudioSource soundSource;

   void Update()
    {
        detectDoor = GameObject.FindWithTag("MainCamera").GetComponent<DetectObject>(); // This will give me the state of DetectDoor from the DetectObject script
        if (detectDoor.DetectDoor == true)

        {
            if (Locked == false) // If the key was destroyed the door will open and play the Door_Open audio clip
            {
                StateMachine.SetBool(AnimationName, true); // Starts the DoorOpen animation by setting the DoorOpenBool to true
                soundSource.clip = soundFiles[0];
                soundSource.Play();
            }
            else
            {
                soundSource.clip = soundFiles[1]; // If the key has not been found and the game object is not destroyed, the door will not open and the Door_Locked audio clip will play
                soundSource.Play();
            }
        }
    }

    public void Unlock()
    {
        if (GameObject.FindWithTag("Key") == null) // Checks to see if the key game object is destroyed, if so it makes Unlock true
            Locked = false;
    }
}
