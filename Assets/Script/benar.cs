using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class benar : MonoBehaviour {
    public Transform transparan;
    public string category;

    public void Start()
    {
        transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
    }

    public void JawabanBenar()
    {
        transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        //Debug.Log("Benar");
        Click.game = 0;
        Debug.Log("Next Level");
        StartCoroutine(reset());
    }

    IEnumerator reset()
    {
        gmScript.count = 0;
        gmScript.currentWord = "Collaborate";
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(category);
    }
}
