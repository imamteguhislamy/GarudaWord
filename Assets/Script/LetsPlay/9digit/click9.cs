using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class click9 : MonoBehaviour
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
            gm9.cek = 1;
            gm9.count++;
            gm9.currentWord += GetComponent<SpriteRenderer>().sprite.name;
            Debug.Log("Count = " + gm9.count);
            Debug.Log(game);
            //FindObjectOfType<benar>().JawabanBenar();
        }
        if (game == 0)
        {
            Debug.Log("Freeze");
        }


    }
}
