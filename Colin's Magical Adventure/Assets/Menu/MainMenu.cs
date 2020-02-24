using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu: MonoBehaviour {

    private void Start()
    {
        
    }
    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("VOUS AVEZ QUITTER LE JEU");
    }
}
