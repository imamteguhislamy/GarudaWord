using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salah11 : MonoBehaviour
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
        popUp11.game = 0;
        gm11.cek = 0;
        //Debug.Log("Muncul");
        StartCoroutine("Delay");
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.5f);
        transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        popUp11.game = 1;
        gm11.count = 0;
        gm11.currentWord = "";

    }

}
