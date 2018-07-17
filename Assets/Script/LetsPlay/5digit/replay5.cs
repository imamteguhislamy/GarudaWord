using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replay5 : MonoBehaviour
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
        popUp5.game = 1;
        gm5.currentWord = "";
        gm5.count = 0;
        Debug.Log(popUp5.game + "-" + gm5.count);
        FindObjectOfType<benar5>().Start();

    }
}
