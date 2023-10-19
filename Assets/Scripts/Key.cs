using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject.Find("PorteDeSotie").GetComponent<Porte>().Askey = true;
            GameObject.Find("SpotLight").SetActive(false);
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            Destroy(GameObject.Find("key_gold"), 0.5f);
        }
    }
}
