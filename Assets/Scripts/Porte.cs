using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porte : MonoBehaviour
{
    public bool Askey = false;
    public GameObject Particule;
    public AudioClip sndAutoriser, sndRefuser;
    AudioSource audioSourcePorte;

    private void Awake()
    {
        audioSourcePorte = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Askey)
        {
            Particule.SetActive(true);
            audioSourcePorte.PlayOneShot(sndAutoriser);
            GameObject.Find("Porte").GetComponent<Animator>().enabled = true;
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
        else
        {
            audioSourcePorte.PlayOneShot(sndRefuser);
        }
       
    }
}
