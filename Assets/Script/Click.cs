using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Click : MonoBehaviour {
    public static int game;
    // Use this for initialization
    void Start () {
        game = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
       if ( game == 1);
        {
            gmScript.cek = 1;
            gmScript.count++;
            gmScript.currentWord += GetComponent<SpriteRenderer>().sprite.name;
            gmScript.letterNum += 1;
            gmScript.selectLetter[gmScript.letterNum] = GetComponent<SpriteRenderer>().sprite.name;

            Debug.Log("Count = " + gmScript.count);
            Debug.Log(game);
        }
        if (game == 0)
        {
            Debug.Log("Freeze");
        }
    }
}
