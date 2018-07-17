using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salah7 : MonoBehaviour
{
    public Transform transparan;

    private void Start()
    {
        transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);

    }
    public void JawabanSalah()
    {
        transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        //Debug.Log("Muncul Icon");
        popUp7.game = 0;
        gm7.cek = 0;
        //Debug.Log("Muncul");
        StartCoroutine("Delay");
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.5f);
        transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        popUp7.game = 1;
        gm7.count = 0;
        gm7.currentWord = "";

    }

}
