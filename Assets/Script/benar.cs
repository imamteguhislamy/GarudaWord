using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class benar : MonoBehaviour {
    public Transform transparan;
    public string category;
    public string soal;
    public RectTransform lett1;
    public RectTransform lett2;
    public RectTransform lett3;

    public static List<string> selectSoal = new List<string>() { "c", "o", "l", "", "", ""};

    public void Start()
    {
        // gmScript.currentWord = "";
        if(gmScript.currentWord == "col")
        {
            lett1.GetComponent<TMPro.TextMeshProUGUI>().text = selectSoal[0];
            lett2.GetComponent<TMPro.TextMeshProUGUI>().text = selectSoal[1];
            lett3.GetComponent<TMPro.TextMeshProUGUI>().text = selectSoal[2];
            gmScript.currentWord = "";
        } else
        { 
            transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }
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
        gmScript.currentWord = soal;
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(category);
    }
}
