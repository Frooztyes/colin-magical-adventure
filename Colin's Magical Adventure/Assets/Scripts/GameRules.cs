using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRules : MonoBehaviour
{
    public GameObject VictoryMessage;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("SheetOpen", 0);
        PlayerPrefs.SetInt("SheetTaken", 0);
        PlayerPrefs.SetInt("SheetsPut", 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Sheets : " + PlayerPrefs.GetInt("SheetsPut"));
        if(PlayerPrefs.GetInt("SheetsPut") == 1)
        {
            VictoryMessage.SetActive(true);
            PlayerPrefs.SetInt("Victory", 0);
        }
    }
}
