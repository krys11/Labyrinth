using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterTime : MonoBehaviour
{
    public int seconde = 5;
    public Text textUI;

    // Start is called before the first frame update
    void Start()
    {
        textUI.text = "Time: " + seconde;
        StartCoroutine(decompte());
    }

    IEnumerator decompte() {
        while (seconde > 0)
        {
            yield return new WaitForSeconds(1f);
            seconde--;
            textUI.text = "Time: " + seconde;
        }

        print("Dead");
        GameObject.Find("Capsule").GetComponent<PlayerControler>().Death();
    }
}
