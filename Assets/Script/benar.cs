using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class benar : MonoBehaviour
{
    public Transform transparan;

    public void Start()
    {
        transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
    }

    public void JawabanBenar()
    {
        transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        //Debug.Log("Benar");
        Click.game = 0;
        Debug.Log("Game = " + Click.game);
        Debug.Log("Next Level");
    }
}
