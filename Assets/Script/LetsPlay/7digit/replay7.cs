using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replay7 : MonoBehaviour
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
        popUp7.game = 1;
        gm7.currentWord = "";
        gm7.count = 0;
        Debug.Log(popUp7.game + "-" + gm7.count);
        FindObjectOfType<benar7>().Start();

    }
}
