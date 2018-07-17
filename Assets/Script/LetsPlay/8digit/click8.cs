using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class click8 : MonoBehaviour
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
            gm8.cek = 1;
            gm8.count++;
            gm8.currentWord += GetComponent<SpriteRenderer>().sprite.name;
            Debug.Log("Count = " + gm8.count);
            Debug.Log(game);
            //FindObjectOfType<benar>().JawabanBenar();
        }
        if (game == 0)
        {
            Debug.Log("Freeze");
        }


    }
}
