using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
 
{
    DetectObject detectSign;
    public string GoToScene;

    void Update()
    {
        detectSign = GameObject.FindWithTag("MainCamera").GetComponent<DetectObject>();
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(GoToScene);
    }
}