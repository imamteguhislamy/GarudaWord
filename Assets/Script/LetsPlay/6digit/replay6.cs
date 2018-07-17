using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replay6 : MonoBehaviour
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
        popUp6.game = 1;
        gm6.currentWord = "";
        gm6.count = 0;
        Debug.Log(popUp6.game + "-" + gm6.count);
        FindObjectOfType<benar6>().Start();

    }
}
