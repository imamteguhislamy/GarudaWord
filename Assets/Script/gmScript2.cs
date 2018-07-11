using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gmScript2 : MonoBehaviour
{
    public static string currentWord;
    public Transform spellWord;
    public Transform result;
    public Transform benar;
    public Transform salah;

    public RectTransform lett1;
    public RectTransform lett2;
    public RectTransform lett3;

    public Transform alphabet1;
    public Transform alphabet2;
    public Transform alphabet3;
    public Transform alphabet4;

    public List<string> availAlpha1 = new List<string>() { "B" };
    public List<string> availAlpha2 = new List<string>() { "A" };
    public List<string> availAlpha3 = new List<string>() { "L" };
    public List<string> availAlpha4 = new List<string>() { "L" };


    public static List<string> selectLetter = new List<string>() { "", "", "", "", "", };
    public static int letterNum = 0;

    public RectTransform ParentPanel;
    private List<string> ImageName;
    private int imageNum = 0;

    public static int count = 0;
    public static int cek = 0;
    // Use this for initialization
    void Start()
    {
        Debug.Log("Start Count = " + count);

      //  alphabet1.GetComponent.< TextMesh > ().text = availAlpha1[0];
      //  alphabet2.GetComponent.< TextMesh > ().text = availAlpha2[0];
      //  alphabet3.GetComponent.< TextMesh > ().text = availAlpha3[0];
       // alphabet4.GetComponent.< TextMesh > ().text = availAlpha4[0];

    }



    // Update is called once per frame
    void Update()
    {
        string soal = "abc";

        //spellWord.GetComponent<TextMesh>().text = currentWord;

        spellWord.GetComponent<TMPro.TextMeshProUGUI>().text = currentWord;
        if (Click.game == 1)
        {
            if (currentWord == soal && count == 3)
            {
                //cek = 1;
                //FindObjectOfType<benar>().JawabanBenar();
                result.GetComponent<TextMesh>().text = "Benar";
                lett1.GetComponent<TMPro.TextMeshProUGUI>().text = selectLetter[1];
                lett2.GetComponent<TMPro.TextMeshProUGUI>().text = selectLetter[2];
                lett3.GetComponent<TMPro.TextMeshProUGUI>().text = selectLetter[3];
            }
            else if (currentWord != soal && count == 3)
            {
                //FindObjectOfType<salah>().JawabanSalah();
                result.GetComponent<TextMesh>().text = "Salah";

                //Debug.Log("Anda Salah");
            }

        }
    }
}
