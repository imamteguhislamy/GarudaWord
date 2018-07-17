using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replay4 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        popUp4.game = 1;
        gm4.currentWord = "";
        gm4.count = 0;
        Debug.Log(popUp4.game + "-" + gm4.count);
        FindObjectOfType<benar4>().Start();

    }
}
