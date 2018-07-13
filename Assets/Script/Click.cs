using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Click : MonoBehaviour {
    public static int game;

    void Start() {
        game = 1;
     
    }
	
	
	void Update () {
		
    
	}

    

    void OnMouseDown()
    {
        if (game == 1)
        {
            gmScript.cek = 1;
            gmScript.count++;
            gmScript.currentWord += GetComponent<SpriteRenderer>().sprite.name;
            Debug.Log("Count = " + gmScript.count);
            Debug.Log(game);
            //FindObjectOfType<benar>().JawabanBenar();
        }
        if (game == 0)
        {
            Debug.Log("Freeze");
        }


    }
}
