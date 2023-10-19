using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    public void Continue()
    {
        int loadLevel = PlayerPrefs.GetInt("DernierNiveau");
        if(loadLevel > 0 ) {
            SceneManager.LoadScene(loadLevel);
        }
        else
        {
            SceneManager.LoadScene("Level1");
        }
    }

    public void LoadLeve1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif

    }
}
