using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replay10 : MonoBehaviour
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
        popUp10.game = 1;
        gm10.currentWord = "";
        gm10.count = 0;
        Debug.Log(popUp10.game + "-" + gm10.count);
        FindObjectOfType<benar8>().Start();

    }
}
