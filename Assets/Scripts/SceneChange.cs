using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void EnterGameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
