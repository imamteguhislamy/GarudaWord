using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replay9 : MonoBehaviour
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
        popUp9.game = 1;
        gm9.currentWord = "";
        gm9.count = 0;
        Debug.Log(popUp9.game + "-" + gm9.count);
        FindObjectOfType<benar8>().Start();

    }
}
