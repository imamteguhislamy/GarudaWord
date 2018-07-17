using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class benar7 : MonoBehaviour
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
    public Image Img;
    public Animator Anim;

    //public static List<string> selectSoal = new List<string>() { "c", "o", "l", "", "", ""};

    public void Start()
    {
        // gmScript.currentWord = "";
        if (gm7.currentWord == soal)
        {
            lett1.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(0, 1);
            lett2.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(1, 1);
            lett3.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(2, 1);
            lett4.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(3, 1);
            lett5.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(4, 1);
            lett6.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(4, 1);
            lett7.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(4, 1);
            popUp7.game = 0;
            gm7.currentWord = "";
        }
        else
        {
            transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }
    }

    public void JawabanBenar()
    {

        transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        StartCoroutine(reset());
    }

    IEnumerator reset()
    {
        popUp7.game = 0;
        gm7.count = 0;
        gm7.currentWord = soal;
        yield return new WaitForSeconds(1f);
        Anim.SetBool("Fade", true);
        yield return new WaitUntil(() => Img.color.a == 1);
        SceneManager.LoadScene(category);
    }
}
