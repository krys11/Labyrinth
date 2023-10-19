using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePlay : MonoBehaviour
{

    [SerializeField]
    bool GamePaused = false;

    [SerializeField]
    GameObject PauseTXT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.F1)){
            if(GamePaused){
                Resume();
            }else{
                Pause();
            }
        }

        if(Input.GetKeyDown(KeyCode.F2)){
           SceneManager.LoadScene("Menu");
        }
    }

    public void Pause(){
        GamePaused = true;
        Time.timeScale = 0f;
        PauseTXT.SetActive(true);
    }
    public void Resume(){
        GamePaused = false;
        Time.timeScale = 1.0f;
        PauseTXT.SetActive(false);
    }
}
