using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class click10 : MonoBehaviour
{
    public static int game;

    void Start()
    {
        game = 1;

    }


    void Update()
    {


    }



    void OnMouseDown()
    {
        if (game == 1)
        {
            gm10.cek = 1;
            gm10.count++;
            gm10.currentWord += GetComponent<SpriteRenderer>().sprite.name;
            Debug.Log("Count = " + gm10.count);
            Debug.Log(game);
            //FindObjectOfType<benar>().JawabanBenar();
        }
        if (game == 0)
        {
            Debug.Log("Freeze");
        }


    }
}
