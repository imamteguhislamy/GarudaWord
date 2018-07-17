using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreList : MonoBehaviour
{

    public GameObject playerScoreEntryPrefab;

    ScoreManager scoreManager;
    int lastChangeCounter;

    void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
        lastChangeCounter = scoreManager.GetChangeCounter();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreManager == null)
        {
            Debug.LogError("Error");
            return;
        }

        if (scoreManager.GetChangeCounter() == lastChangeCounter)
        {
            return;
        }

        lastChangeCounter = scoreManager.GetChangeCounter();

        while (this.transform.childCount > 0)
        {
            Transform c = this.transform.GetChild(0);
            c.SetParent(null);
            Destroy(c.gameObject);
        }

        string[] names = scoreManager.GetPlayerNames("Score");

        foreach (string name in names)
        {
            GameObject go = (GameObject)Instantiate(playerScoreEntryPrefab);
            go.transform.SetParent(this.transform);
            go.transform.Find("Username").GetComponent<TMPro.TextMeshProUGUI>().text = name;
            go.transform.Find("ID Pegawai").GetComponent<TMPro.TextMeshProUGUI>().text = scoreManager.GetScore(name, "ID Pegawai").ToString();
            //go.transform.Find("Divisi").GetComponent<TMPro.TextMeshProUGUI>().text = scoreManager.GetScore(name, "Divisi").ToString();
            go.transform.Find("Score").GetComponent<TMPro.TextMeshProUGUI>().text = scoreManager.GetScore(name, "Score").ToString();
        }
    }
}
