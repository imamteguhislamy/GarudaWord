using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replay11 : MonoBehaviour
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
        popUp11.game = 1;
        gm11.currentWord = "";
        gm11.count = 0;
        Debug.Log(popUp11.game + "-" + gm11.count);
        FindObjectOfType<benar11>().Start();

    }
}
