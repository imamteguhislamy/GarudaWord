using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gmScript : MonoBehaviour
{
    public static string currentWord;
    public Transform spellWord;

    public RectTransform lett1;
    public RectTransform lett2;
    public RectTransform lett3;

    public static List<string> selectLetter = new List<string>() { "", "", "", "", "", "" };
    public static List<string> selectSoal = new List<string>() { "a", "b", "c", "", "", ""};
    public static int letterNum = 0;

   // public RectTransform ParentPanel;
   // private List<string> ImageName;
  //  private int imageNum = 0;

    public static int count = 0;
    public static int cek = 0;
    public static int timer = 0;

    // Use this for initialization
    void Start()
    {
       // Debug.Log("Start Count = " + count);

      }

   

    // Update is called once per frame
    void Update()
    {
        string soal = "abc";


    
        if (Click.game == 1)
        {
            spellWord.GetComponent<TMPro.TextMeshProUGUI>().text = currentWord;
            if (currentWord == soal && count == 3)
            {
                cek = 1;
                FindObjectOfType<benar>().JawabanBenar();
               // result.GetComponent<TextMesh>().text = "Benar";
                lett1.GetComponent<TMPro.TextMeshProUGUI>().text = selectSoal[0];
                lett2.GetComponent<TMPro.TextMeshProUGUI>().text = selectSoal[1];
                lett3.GetComponent<TMPro.TextMeshProUGUI>().text = selectSoal[2];
            }
            else if (currentWord != soal && count == 3)
            {
                FindObjectOfType<salah>().JawabanSalah();
               // result.GetComponent<TextMesh>().text = "Salah";

                //Debug.Log("Anda Salah");
            }

        }
    }
}
