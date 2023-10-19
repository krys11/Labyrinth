using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    public float vitesse;
    public GameObject ImgGameOver;
    float vitesseActuelle;
    public float rotate = 90f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            vitesseActuelle = vitesse * 2;
        }
        else
        {
            vitesseActuelle = vitesse;
        }

        transform.Translate(Vector3.forward * vitesseActuelle * Time.fixedDeltaTime * Input.GetAxis("Vertical"));

        transform.Rotate(Vector3.up * rotate * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
    }

    public void LoadNextScene()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextScene = sceneIndex + 1;
        PlayerPrefs.SetInt("DernierNiveau", nextScene);
        SceneManager.LoadScene(sceneIndex + 1);
    }

    public void Death()
    {
        ImgGameOver.SetActive(true);
        StartCoroutine(LoadMenu());
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Menu");
    }
}
