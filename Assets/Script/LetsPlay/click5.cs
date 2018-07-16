using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Click5 : MonoBehaviour
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
            gm5.cek = 1;
            gm5.count++;
            gm5.currentWord += GetComponent<SpriteRenderer>().sprite.name;
            Debug.Log("Count = " + gm5.count);
            Debug.Log(game);
            //FindObjectOfType<benar>().JawabanBenar();
        }
        if (game == 0)
        {
            Debug.Log("Freeze");
        }


    }
}
