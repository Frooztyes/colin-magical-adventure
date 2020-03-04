using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRules : MonoBehaviour
{
    public GameObject VictoryMessage;
    public GameObject DeathMessage;
    public AudioSource DeathSound;
    public Timer timer;
    private bool DeathSoundPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("SheetOpen", 0);
        PlayerPrefs.SetInt("SheetTaken", 0);
        PlayerPrefs.SetInt("SheetsPut", 0);
        PlayerPrefs.SetInt("Victory", 0);
        PlayerPrefs.SetInt("IsDead", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("SheetsPut") == 1)
        {
            VictoryMessage.SetActive(true);
            PlayerPrefs.SetInt("Victory", 1);
        }

        if(PlayerPrefs.GetInt("IsDead") == 1)
        {
            DeathMessage.SetActive(true);
            if(!DeathSoundPlaying)
                DeathSound.Play();
            DeathSoundPlaying = true;
            timer.Stop();
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
