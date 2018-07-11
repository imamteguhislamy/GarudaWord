using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Click.game = 1;
        gmScript.currentWord = "";
        gmScript.count = 0;
        Debug.Log(Click.game + "-" + gmScript.count);
        FindObjectOfType<benar>().Start();

    }
}
