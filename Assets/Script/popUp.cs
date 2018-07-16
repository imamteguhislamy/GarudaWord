using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popUp : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton;
    public static int game;

    void Start()
    {
        game = 1;
        Button btn1 = m_YourFirstButton.GetComponent<Button>();

        //Calls the TaskOnClick/TaskWithParameters method when you click the Button
        btn1.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (game == 1) ;
        {
            //Debug.Log("tempe");
            gmScript.cek = 1;
            gmScript.count++;
            //gmScript.currentWord += GetComponent<SpriteRenderer>().sprite.name;
            //gmScript.currentWord += EventSystem.current.currentSelectedGameObject.name;
            gmScript.currentWord += GetComponent<TextMesh>().text;

            gmScript.letterNum += 1;
            // gmScript.selectLetter[gmScript.letterNum] = GetComponent<SpriteRenderer>().sprite.name;
            // gmScript.selectLetter[gmScript.letterNum] = EventSystem.current.currentSelectedGameObject.name;
            gmScript.selectLetter[gmScript.letterNum] = GetComponent<TextMesh>().text;
            Debug.Log("Count = " + gmScript.count);
            Debug.Log(game);
        }
        if (game == 0)
        {
            Debug.Log("Freeze");
        }
    }
}