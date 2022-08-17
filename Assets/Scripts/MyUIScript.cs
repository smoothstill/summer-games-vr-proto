using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyUIScript : MonoBehaviour
{

    public void RestartOnClick(){
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
	}
    public void QuitOnClick()
    {
        Debug.Log("You pressed quit");
        Application.Quit();
	}
}
