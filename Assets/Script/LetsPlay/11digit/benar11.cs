using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class benar11 : MonoBehaviour
{
    public Transform transparan;
    public string category;
    public string soal;

    public RectTransform lett1;
    public RectTransform lett2;
    public RectTransform lett3;
    public RectTransform lett4;
    public RectTransform lett5;
    public RectTransform lett6;
    public RectTransform lett7;
    public RectTransform lett8;
    public RectTransform lett9;
    public RectTransform lett10;
    public RectTransform lett11;
    public Image Img;
    public Animator Anim;

    public void Start()
    {
        // gmScript.currentWord = "";
        if (gm11.currentWord == soal)
        {
            lett1.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(0, 1);
            lett2.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(1, 1);
            lett3.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(2, 1);
            lett4.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(3, 1);
            lett5.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(4, 1);
            lett6.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(5, 1);
            lett7.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(6, 1);
            lett8.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(7, 1);
            lett9.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(8, 1);
            lett10.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(9, 1);
            lett11.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(10, 1);
            popUp11.game = 0;
            gm11.currentWord = "";
        }
        else
        {
            transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }
    }

    public void JawabanBenar()
    {

        transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        //Debug.Log("Benar");
        popUp11.game = 0;
        Debug.Log("Next Level");
        StartCoroutine(reset());
    }

    IEnumerator reset()
    {
        gm11.count = 0;
       gm11.currentWord = soal;
        yield return new WaitForSeconds(1f);
        Anim.SetBool("Fade", true);
        yield return new WaitUntil(() => Img.color.a == 1);
        SceneManager.LoadScene(category);
    }
}
