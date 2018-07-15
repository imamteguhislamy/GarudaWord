using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hint : MonoBehaviour
{

    // Use this for initialization
    public static int hintCount;
    public RectTransform lett1;
    public RectTransform lett2;
    public RectTransform lett3;
    public static List<string> lett = new List<string>() { "lett1", "lett2", "lett3"};


    void Start()
    {
        hintCount = 3;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (hintCount >= 3) 
        {
             lett1.GetComponent<TMPro.TextMeshProUGUI>().text = gmScript.selectLetter[1];
            hintCount -= 1;
        } else if (hintCount >= 2)
        {
            lett2.GetComponent<TMPro.TextMeshProUGUI>().text = gmScript.selectLetter[2];
            hintCount -= 1;
        } else if (hintCount >= 1)
        {
            lett3.GetComponent<TMPro.TextMeshProUGUI>().text = gmScript.selectLetter[2];
            hintCount -= 1;
        }
    }
}
