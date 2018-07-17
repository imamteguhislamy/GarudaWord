using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class gm6 : MonoBehaviour
{
    public static string currentWord;
    // public static string soal;

    public Transform spellWord;
    public Transform result;
    public Transform score;
    public Transform SkorTersimpan;

    public RectTransform lett1;
    public RectTransform lett2;
    public RectTransform lett3;
    public RectTransform lett4;
    public RectTransform lett5;
    public RectTransform lett6;

    public string soal = "trust";

    public static List<string> selectLetter = new List<string>() { "", "", "", "", "", "" };
    public static int letterNum = 0;

    // public RectTransform ParentPanel;
    // private List<string> ImageName;
    //  private int imageNum = 0;

    public static int count = 0;
    public static int cek = 0;
    public static int timer = 0;
    public static int nilai;
    public static int SavedScore;

    // Use this for initialization
    void Start()
    {
        LoadScore();
        SkorTersimpan.GetComponent<TMPro.TextMeshProUGUI>().text = SavedScore.ToString();
        // Debug.Log("Start Count = " + count);
    }



    // Update is called once per frame
    void Update()
    {

        if (popUp6.game == 1)
        {

            spellWord.GetComponent<TMPro.TextMeshProUGUI>().text = currentWord;
            if (currentWord == soal && count == soal.Length)
            {
                cek = 1;
                nilai += 10;
                score.GetComponent<TMPro.TextMeshProUGUI>().text = nilai.ToString();
                FindObjectOfType<benar6>().JawabanBenar();
                // result.GetComponent<TextMesh>().text = "Benar";
                lett1.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(0, 1);
                lett2.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(1, 1);
                lett3.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(2, 1);
                lett4.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(3, 1);
                lett5.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(4, 1);
                lett6.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(5, 1);
            }
            else if (currentWord != soal && count == soal.Length)
            {
                FindObjectOfType<salah6>().JawabanSalah();
                // result.GetComponent<TextMesh>().text = "Salah";

                //Debug.Log("Anda Salah");
            }

        }
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("Score", nilai);
    }

    public void LoadScore()
    {
        SavedScore = PlayerPrefs.GetInt("Score", 0);
    }

    public void DeleteScore()
    {
        PlayerPrefs.DeleteKey("Score");
    }

}